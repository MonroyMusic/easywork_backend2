import { json } from "react-router-dom"
import { constants } from "../helpers/constants"

const api = constants().API_URL

const getToken = () => {
    const userData = JSON.parse(localStorage.getItem('user'))
    return userData?.token
}

export const fetchBase = async ({
    metodo,
    recurso,
    body
}) => {
    console.log(recurso);
    const res = await fetch(`${api}/${recurso}`, {

        method: metodo,
        headers: {
            'Content-Type': 'application/json',
            'Authorization': getToken() ? `Bearer ${getToken()}` : undefined,
        },
        body: JSON.stringify(body)
    })

    const parcedData = await res.json()

    if (!parcedData.status) {
        return {
            status: parcedData.status,
            message: 'error',
            data: null
        }
    }

    return {
        status: parcedData.status,
        message: parcedData.message,
        data: parcedData.data
    }
}