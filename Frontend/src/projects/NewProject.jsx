import { useState } from "react";
import { useNavigate } from "react-router-dom";

const NewProject = ({ onProjectCreated }) => {

  const [newProject, setNewProject] = useState({
    nameProject: '',
    description: '',
    finishDate: '',
    projectType: ''
  });

  const navigate = useNavigate();

  const handleSubmit = async (e) => {
    e.preventDefault();

    if (errors.length === 0) {
      //console.log('no hay errores')
      try {
        const response = await fetch(`${API_URL}/auth/...`, {
          method: 'POST',
          headers: {
            'Content-Type': 'application/json',
          },
          body: JSON.stringify(newProject)

        });
        console.log(newProject);
        onProjectCreated(newProject.nameProject);
        navigate("/home");


        if (!response.ok) {
          throw new Error('Fallo en la creacion de proyecto');
        }

        const result = await response.json();
        login(result.data);

      } catch (error) {
        console.log(error);
      }

    }
  }


  return (
    <div className="flex">
      <div className="flex flex-col justify-center items-center p-3 w-full h-full   md:h-screen">
        <h1 className="text-3xl text-white font-bold mb-6">Nuevo proyecto</h1>
        <form
          onSubmit={handleSubmit}
          className="bg-blue-ligth rounded-md w-7/12 p-6">
          <div className="flex flex-col mb-4">
            <label className="text-white font-semibold mb-2">
              Nombre del proyecto
            </label>
            <input
              className="border-2 w-full p-2 placeholder-gray-600 rounded-md"
              type="text"
              placeholder="Nombre de nuevo proyecto"
              value={newProject.nameProject}
              onChange={(e) => setNewProject({ ...newProject, nameProject: e.target.value })}
            />
          </div>

          <div className="flex flex-col mb-4">
            <label className="text-white font-semibold mb-2">Descripcion</label>
            <input
              className="border-2 w-full p-2 placeholder-gray-600 rounded-md"
              type="text"
              placeholder="Descripcion"
              value={newProject.description}
              onChange={(e) => setNewProject({ ...newProject, description: e.target.value })}
            />
          </div>

          <div className="flex flex-col mb-4">
            <label className="text-white font-semibold mb-2">
              Fecha de finalización
            </label>
            <input
              className="border-2 w-full p-2 placeholder-gray-600 rounded-md"
              type="date"
              value={newProject.finishDate}
              onChange={(e) => setNewProject({ ...newProject, finishDate: e.target.value })}
            />
          </div>

          <div className="flex flex-col mb-4">
            <label className="text-white font-semibold mb-2">
              Tipo de Proyecto
            </label>
            <input
              className="border-2 w-full p-2 placeholder-gray-600 rounded-md"
              type="text"
              placeholder="Tipo de proyecto"
              value={newProject.projectType}
              onChange={(e) => setNewProject({ ...newProject, projectType: e.target.value })}
            />
          </div>


          <div className="text-white mt-3 flex items-center justify-center">
            <button type="button" className="bg-blue rounded-md p-2">Crear Proyecto</button>

            <span
              className="bg-blue rounded-md p-2 ml-7 cursor-pointer"
              onClick={() => navigate("/home")}
            >
              Cancelar
            </span>
          </div>
        </form>
      </div>
    </div>
  );
};

export default NewProject;
