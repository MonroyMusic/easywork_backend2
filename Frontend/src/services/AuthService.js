import { fetchBase } from "./httpService"

export const AuthService = {
    login: async (userName, pass) => {
        const { data } = await fetchBase({
            metodo: "POST",
            body: {
                userName: userName,
                passoword: pass
            },
            recurso: "auth/login"
        })

        return {
            email: data.email,
            token: data.token,
            tokenExpiration: data.tokenExpiration
        }
    }
}