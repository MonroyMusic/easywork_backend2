import { FiEyeOff } from "react-icons/fi";
import { MdOutlineEmail } from "react-icons/md";
import { CiLock } from "react-icons/ci";
import { LuEye } from "react-icons/lu";
import { useState } from "react";
import { useNavigate } from "react-router-dom";
import { constants } from '../helpers/constants';

const Login = () => {
  //Estado para mostrar contraseña
  const [showPassword, setShowPassword] = useState(false);

  const [loginForm, setLoginForm] = useState({
    userName: '',
    password: ''
  });

  const { API_URL } = constants();

  const handleShowPassword = async (e) => {

    setShowPassword(!showPassword);
  };

  const navigate = useNavigate();

  const handleSubmit = () => {
    e.preventDefault();

    try {
      const response = fetch(`${API_URL}/auth/login`, {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(loginForm)
      });

      if (!response.ok) {
        throw new Error('Error en el inicio de sesión');
      }

      const result = response.json();
      navigate("/home");

    } catch (error) {
      console.log(error);
    }

  }

  return (
    <div className="md:flex">
      <div className="bg-blue-ligth h-screen md:w-1/2 lg:w-2/5 container flex justify-center items-center">
        <div className="p-2 rounded-md bg-gray-300">
          <div className="p-2 rounded-md bg-blue-ligth">
            <div className="p-8 rounded-lg w-full md:w-96">
              <div className="mb-10">
                <h1 className="text-3xl text-center text-blue uppercase font-bold">
                  Inicio de Sesión
                </h1>
              </div>

              <form onSubmit={handleSubmit}>
                <div className="relative">
                  <MdOutlineEmail className="absolute left-2 top-1/2 -translate-y-1/2 text-gray-500" />
                  <input
                    type="text"
                    className="w-full border border-gray-600 outline-none px-8 py-2 rounded-lg"
                    placeholder="Username"
                    value={loginForm.userName}
                    onChange={(e) => setLoginForm({ ...loginForm, userName: e.target.value })}
                  />
                </div>

                <div className="relative mt-7">
                  <CiLock className="absolute left-2 top-1/2 -translate-y-1/2 text-gray-500" />
                  <input
                    type={showPassword ? "text" : "password"}
                    className="w-full border border-gray-600 outline-none px-8 py-2 rounded-lg"
                    placeholder="Contraseña"
                    value={loginForm.password}
                    onChange={(e) => setLoginForm({ ...loginForm, password: e.target.value })}
                  />
                  {showPassword ? (
                    <LuEye
                      onClick={handleShowPassword}
                      className="absolute right-2 top-1/2 -translate-y-1/2 text-gray-500"
                    />
                  ) : (
                    <FiEyeOff
                      onClick={handleShowPassword}
                      className="absolute right-2 top-1/2 -translate-y-1/2 text-gray-500"
                    />
                  )}
                </div>

                <div className="text-white text-sm mt-4 ">
                  <a className="p-2 hover:font-bold hover:underline" href="">
                    ¿Olvidaste tu contraseña?
                  </a>
                  <a
                    className="p-4 hover:font-bold hover:underline"
                    href="/registro"
                  >
                    Registrarme
                  </a>
                </div>

                <button
                  type="submit"
                  className="bg-blue text-white rounded-xl w-full uppercase mt-4 p-2 
                hover:bg-blue-trans cursor-pointer"
                >
                  Inicias Sesion
                </button>

              </form>
            </div>
          </div>
        </div>
      </div>

      <div className="h-screen">
        <img
          src="./src/img/Principal.jpg"
          className="object-cover w-full h-full"
        />
      </div>
    </div>
  );
};

export default Login;
