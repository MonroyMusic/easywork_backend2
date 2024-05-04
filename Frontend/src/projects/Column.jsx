import { Droppable } from "react-beautiful-dnd"

const Column = ({ title, task, id }) => {
    return (
        <div className="container">
            <h1>hi</h1>
            <Droppable droppableId={id}>
                {(provided, snapshot) => {
                    <TaskList
                        ref={provided.innerRef}
                        {...provided.droppableProps}
                        isDragginOver={snapshot.isDraggingOver}
                    >
                        {provided.placeholder}

                    </TaskList>
                }
                }

            </Droppable>
        </div>
    )
}

export default Column