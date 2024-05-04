import MUIDataTable from "mui-datatables";
import { Title } from "../components/Title"
import { ThemeProvider, createTheme } from "@mui/material";
import { useEffect, useState } from "react";
import { LogService } from "../services/logtService copy";

const columns = [
    {
        label: "Acción",
        name: ""
    },
    {
        label: "Fecha",
        name: ""
    },
    {
        label: "UsuarioId",
        name: ""
    },
];

const Record = () => {
    const [data, setData] = useState([])

    useEffect(() => {
        LogService.getAll().then(d => {
            setData(d)
        })
    }, [])



    const options = {
        selectableRows: false,
        elevation: 0,
        rowsPerPage: 5,
        rowsPerPageOptions: [5, 10, 15, 20],
    };

    const getMuiTheme = () =>
        createTheme({
            typography: {
                fontFamily: "Poppins",
            },
            palette: {
                background: {
                    paper: "#697A98",
                    default: "#B8BFD6",
                },
                mode: "dark",
            },
            components: {
                MuiTableOverrides: {
                    head: {
                        Padding: "10px 4px",
                    },
                    body: {
                        Padding: "7px 15px",
                        color: "#FFFF",
                    },
                    footer: {
                        fontFamily: "Poppins",
                    },
                },
            },
        });

    return (
        <div>
            <Title>Historial</Title>
            <div className="flex justify-center  ">
                <ThemeProvider theme={getMuiTheme()}>
                    <MUIDataTable
                        className="w-full"
                        data={data}
                        columns={columns}
                        options={options}
                    />
                </ThemeProvider>
            </div>

        </div>
    )
}

export default Record
