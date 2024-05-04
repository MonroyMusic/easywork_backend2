import { Route, Routes } from "react-router-dom";
import Login from "../AuthPages/Login";
import Sidebar from "../components/Sidebar";
import Home from "../ListPages/Home";
import Tasks from "../ListPages/Tasks";
import Progress from "../ListPages/Progress";

import Account from "../ListPages/Account";
import NewProject from "../projects/NewProject";
import Register from "../AuthPages/Register";
import MyCalendar from "../ListPages/MyCalendar";
import { Navigate } from "react-router-dom";
import { Outlet } from "react-router-dom";
import Record from "../ListPages/Record";
import Project from "../projects/Project";
import { PublicRoute } from "./PublicRoute";
import { PrivateRoute } from "./PrivateRoute";



const AppRouter = () => {
  return (
    <Routes>

      <Route
        path="/"
        element={
          <PublicRoute>
            <Login />
          </PublicRoute>
        }
      />
      <Route
        path="/registro"
        element={
          <PublicRoute>
            <Register />
          </PublicRoute>
        }
      />


      <Route
        element={
          <div className="flex w-full flex-1 h-screen bg-gray-blue">
            <Sidebar />
            <div className="flex-1 container-md mx-10">
              <PrivateRoute>
                <Outlet />
              </PrivateRoute>
            </div>
          </div>
        }
      >
        <Route path="/home" element={<Home />} />
        <Route path="/tareas" element={<Tasks />} />
        <Route path="/progresos" element={<Progress />} />
        <Route path="/calendario" element={<MyCalendar />} />
        <Route path="/cuenta" element={<Account />} />
        <Route path="/crearProyecto" element={<NewProject />} />
        <Route path="/historial" element={<Record />} />
        <Route path="proyecto" element={<Project />} />
      </Route>
    </Routes>
  );
};

export default AppRouter;
