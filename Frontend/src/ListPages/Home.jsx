import { useNavigate } from "react-router-dom";
import { Title } from "../components/Title";
import Card from "../projects/Card";

const Home = ( {Projects} ) => {
  const navigate = useNavigate();

  const handleNewProject = () => {
    navigate("/crearProyecto");
  };

  return (
    <div className=" items-center p-4 text-white">
      <Title>Proyectos</Title>

      <button
        className="flex-grow flex absolute top-0 right-0 mt-14 mr-16 justify-end rounded-md
         bg-blue-ligth p-2 tracking-tight hover:scale-105 hover:shadow cursor-pointer"
        type="button"
        onClick={handleNewProject}
      >
        Nuevo Proyecto
      </button>

      {/* Tarjetas de proyectos creados: iterar los titulos de los proyectos creados */}

      
      {/* <ul className="flex flex-wrap gap-4 p-8 ">
        {Projects.map((project, index) => (
          <Card key={index} title={project} />
        ))}
      </ul>  */}


    </div>
  );
};

export default Home;
