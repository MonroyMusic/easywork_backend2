import Sidebar from "../components/Sidebar";
import { FiEyeOff } from "react-icons/fi";
import { LuEye } from "react-icons/lu";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { constants } from "../helpers/constants";

const Account = () => {
  const [showPassword, setShowPassword] = useState(false);

  const [changeAccount, setChangeAccount] = useState({
    email: '',
    name: '',
    lastName: '',
    password: ''
  });

  const handleShowPassword = () => {
    setShowPassword(!showPassword);
  };

  const { API_URL } = constants();
  const navigate = useNavigate();

  return (
    <div className="flex">
      <div className="flex flex-col justify-center items-center p-3 w-full h-full   md:h-screen">
        <h1 className="text-3xl text-white font-bold mb-6">
          Ajustes de Perfil
        </h1>

        <form className="bg-blue-ligth rounded-md w-4/12 p-6">
          <div className="flex flex-col mb-4">
            <label className="text-white font-semibold mb-2">
              Cambiar Correo Electronico
            </label>
            <input
              className="border-2 w-full p-2 placeholder-gray-600 rounded-md"
              type="email"
              placeholder="Nuevo Correo Electronico"
            />
          </div>

          <div className="flex flex-row justify-between mb-4">
            <div className="flex flex-col w-1/2 mr-2">
              <label className="text-white font-semibold mb-2">
                Cambiar Nombre
              </label>
              <input
                className="border-2 w-full p-2 placeholder-gray-600 rounded-md"
                type="text"
                placeholder="Nombre"
              />
            </div>

            <div className="flex flex-col w-1/2 mr-2">
              <label className="text-white font-semibold mb-2">
                Cambiar Apellido
              </label>
              <input
                className="border-2 w-full p-2 placeholder-gray-600 rounded-md"
                type="text"
                placeholder="Apellido"
              />
            </div>
          </div>

          {/* CAMBIAR CONTRA */}
          <div className="flex flex-col mb-4 relative mt-3">
            <label className="text-white font-semibold mb-2">
              Cambiar Contraseña
            </label>
            <input
              className="w-full border border-gray-600 px-3 py-2 rounded-lg placeholder-gray-600"
              type={showPassword ? "text" : "password"}
              placeholder="Escriba su contraseña"
            />

            <div className="absolute inset-y-0 right-0 flex items-center mt-7">
              {showPassword ? (
                <LuEye
                  onClick={handleShowPassword}
                  className="absolute right-2 top-1/2 -translate-y-1/2 text-gray-500"
                />
              ) : (
                <FiEyeOff
                  onClick={handleShowPassword}
                  className="absolute  right-2 top-4 top-16-translate-y-1/2 text-gray-500"
                />
              )}
            </div>
          </div>

          {/* CONFIRMAR CONTRA */}

          <div className="flex flex-col mb-4 relative mt-3">
            <label className="text-white font-semibold mb-2">
              Confirmar Contraseña
            </label>
            <input
              className="w-full border border-gray-600 px-3 py-2 rounded-lg placeholder-gray-600"
              type={showPassword ? "text" : "password"}
              placeholder="Confirma contraseña"
            />

            <div className="absolute inset-y-0 right-0 flex items-center mt-7">
              {showPassword ? (
                <LuEye
                  onClick={handleShowPassword}
                  className="absolute right-2 top-1/2 -translate-y-1/2 text-gray-500"
                />
              ) : (
                <FiEyeOff
                  onClick={handleShowPassword}
                  className="absolute  right-2 top-4 top-16-translate-y-1/2 text-gray-500"
                />
              )}
            </div>
          </div>

          <div className="text-white mt-3 flex items-center justify-center">
            <input
              className="flex items-center justify-center bg-blue rounded-md p-2 text-white font-bold text-center"
              type="button"
              value={"Editar Perfil"}
            />

            <span
              className="flex items-center justify-center bg-blue rounded-md p-2 ml-10 text-white font-bold text-center"
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

export default Account;
