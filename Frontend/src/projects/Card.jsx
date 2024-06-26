
const Card = ({ title }) => {

    return (
        <div className="bg-blue-ligth hover:border-blue-ligth  w-64 p-4 shadow-2xl flex items-center justify-center cursor-pointer">
            <button className="cursor-pointer">{title}</button>
        </div>
    )
}

export default Card

// bg-gradient-to-r from-gray-blue