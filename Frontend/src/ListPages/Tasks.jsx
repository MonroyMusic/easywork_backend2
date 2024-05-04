 import { useState } from "react";
import { DragDropContext } from "react-beautiful-dnd";
import { Title } from "../components/Title";

const Tasks = () => {
  const [todo, setTodo] = useState([]);
  const [doing, setdoing] = useState([]);
  const [done, setdone] = useState([]);
  return (
    <div>
      <DragDropContext>
        <Title>Tareas</Title>

        <div className="flex justify-between items-center flex-row">
          {/* <Column title={"TO DO"} task={incomplete} id={"1"} /> */}
        </div>
      </DragDropContext>
    </div>
  );
};

export default Tasks;
