import Sidebar from "../components/Sidebar"

const Layout = ({ children }) => {
  return (
    <div className="flex">
    <Sidebar />
    <div className="p-7">{children}</div>
  </div>
  )
}

export default Layout