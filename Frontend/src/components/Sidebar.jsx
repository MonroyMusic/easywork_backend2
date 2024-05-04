import { useState } from "react";
import { CiLogout } from "react-icons/ci";
import { GoArrowLeft } from "react-icons/go";
import { IoHomeOutline } from "react-icons/io5";
import { LiaTasksSolid } from "react-icons/lia";
import { SlCalender, SlChart } from "react-icons/sl";
import { VscAccount } from "react-icons/vsc";
import { useNavigate } from "react-router-dom";
import { LiaHistorySolid } from "react-icons/lia";

const NavItem = ({ icon, title, onClick, open }) => (
  <li
    className="text-white text-sm flex items-center gap-x-4 cursor-pointer 
      p-2 hover:bg-gray-blue rounded-md mt-2"
    onClick={onClick}
  >
    <span className="block float-left text-2xl">{icon}</span>
    <span className={`block duration-100 ${open ? "visible" : "scale-0"}`}>
      <span className="text-lg">{title}</span>
    </span>
  </li>
);


const Sidebar = () => {
  const [open, setOpen] = useState(true);
  const navigate = useNavigate();

  return (
    <div className="flex">
      <div
        className={`bg-blue-ligth h-screen p-5  pt-8 ${open ? "w-56" : "w-20"
          } duration-300 relative`}
      >
        <GoArrowLeft
          className={`bg-white text-blue-ligth text-2xl rounded-full absolute -right-3 
      top-9 border border-blue-ligth cursor-pointer ${!open && "rotate-180"}`}
          onClick={() => setOpen(!open)}
        />

        <div className="inline-flex">
          <img
            src="/src/img/EasyWork.png"
            className="rounded-full w-9 cursor-pointer block"
          />
          <h1
            className={`text-white origin-left font-bold text-2xl p-1 mr-2 ${!open && "scale-0"
              }`}
          >
            EasyWork
          </h1>
        </div>

        <ul className="pt-2">
          <NavItem
            icon={<IoHomeOutline />}
            onClick={() => navigate("/home")}
            open={open}
            title={"Home"}
          />

          <NavItem
            icon={<LiaTasksSolid />}
            onClick={() => navigate("/tareas")}
            open={open}
            title={"Tareas"}
          />

          <NavItem
            icon={<SlChart />}
            onClick={() => navigate("/progresos")}
            open={open}
            title={"Progresos"}
          />

          <NavItem
            icon={<SlCalender />}
            onClick={() => navigate("/calendario")}
            open={open}
            title={"Calendario"}
          />

          <NavItem
            icon={<LiaHistorySolid />}
            onClick={() => navigate("/historial")}
            open={open}
            title={"Historial"}
          />
        </ul>

        <ul className="  absolute bottom-2 ">
          <NavItem
            icon={<VscAccount />}
            onClick={() => navigate("/cuenta")}
            open={open}
            title={"Perfil"}
          />

          <NavItem
            icon={<CiLogout />}
            onClick={() => navigate("/login")}
            open={open}
            title={"Cerrar Sesion"}
          />
        </ul>
      </div>
    </div>
  );
};

export default Sidebar;

