import { FiEyeOff } from "react-icons/fi";
import { MdOutlineEmail } from "react-icons/md";
import { CiLock } from "react-icons/ci";
import { LuEye } from "react-icons/lu";
import { useState } from "react";

const Register = () => {
  const [showPassword, setShowPassword] = useState(false);

  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const handleShowPassword = () => {
    setShowPassword(!showPassword);
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log(email, password);
  };

  return (
    <div className="md:flex">
      <div className="h-screen md:w:1/2">
        <img
          src="./src/img/Principal.jpg"
          className="object-cover float-left w-full h-full"
        />
      </div>

      {/* FORMULARIO */}
      <div className="bg-blue-ligth h-screen lg:w-2/5 container flex justify-center items-center">
        <div className="p-2 rounded-md bg-gray-300">
          <div className="p-2 rounded-md bg-blue-ligth">
            <div className="p-8 rounded-lg w-full md:w-96">
              <div className="mb-10">
                <h1 className="text-3xl text-center text-blue uppercase font-bold">
                  Registrarte
                </h1>
              </div>

              <form onSubmit={handleSubmit}>
                <div className="relative">
                  <MdOutlineEmail className="absolute left-2 top-1/2 -translate-y-1/2 text-gray-500" />
                  <input
                    type="email"
                    className="w-full border border-gray-600 outline-none px-8 py-2 rounded-lg"
                    placeholder=" Correo Electrónico"
                    value={email}
                    onChange={(e) => setEmail(e.target.value)}
                  />
                </div>

                <div className="relative mt-7">
                  <CiLock className="absolute left-2 top-1/2 -translate-y-1/2 text-gray-500" />
                  <input
                    type={showPassword ? "text" : "password"}
                    className="w-full border border-gray-600 outline-none px-8 py-2 rounded-lg"
                    placeholder="Contraseña"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
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

                {/* CONFIRMAR CONTRA */}
                <div className="relative mt-7">
                  <CiLock className="absolute left-2 top-1/2 -translate-y-1/2 text-gray-500" />
                  <input
                    type={showPassword ? "text" : "password"}
                    className="w-full border border-gray-600 outline-none px-8 py-2 rounded-lg"
                    placeholder="Confirmar Contraseña"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
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

                <input
                  type="submit"
                  className="bg-blue text-white rounded-xl w-full uppercase mt-4 p-2 hover:bg-blue-trans cursor-pointer"
                  value={"Registrarte"}
                />
              </form>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Register;
