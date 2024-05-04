import Sidebar from "../components/Sidebar";
import MUIDataTable from "mui-datatables";
import { createTheme, ThemeProvider } from "@mui/material/styles";
import { Padding } from "@mui/icons-material";
import { Title } from "../components/Title";

const columns = ["Proyecto", "Fecha inicio", "Fecha final", "Estado", "Avance"];

const Progress = () => {
  const data = [
    ["Proyecto final", "07/abril/2024", "02/mayo/2024", "doing", ""],
    
  ];

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
          default: "#17407D",
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

  // theme={getMuiTheme()}

  return (
    <div>
      <Title>Avances de Proyecto</Title>
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
  );
};

export default Progress;
