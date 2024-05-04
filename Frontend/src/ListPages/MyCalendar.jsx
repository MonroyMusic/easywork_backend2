import dayjs from "dayjs";
import { Calendar, dayjsLocalizer } from "react-big-calendar";
import "react-big-calendar/lib/css/react-big-calendar.css";
import { Title } from "./../components/Title";
dayjs.locale("es");

const localizer = dayjsLocalizer(dayjs);

// CustomToolbar traduce los botones de la barra de los botones
const CustomToolbar = ({ label, onNavigate, onView }) => (
  <div className="rbc-toolbar">
    <span className="rbc-btn-group">
      <button type="button" onClick={() => onNavigate("TODAY")}>
        Hoy
      </button>
      <button type="button" onClick={() => onNavigate("PREV")}>
        Atrás
      </button>
      <button type="button" onClick={() => onNavigate("NEXT")}>
        Siguiente
      </button>
    </span>
    <span className="rbc-toolbar-label">{label}</span>
  </div>
);

const MyCalendar = () => {
  //Evento que recibira el calendario
  const events = [
    {
      start: dayjs("2024-04-30T12:00:00").toDate(),
      end: dayjs("2024-04-30T13:00:00").toDate(),
      title: "prueba",
    },
  ];

  return (
    <div className=" w-full   ">
      <Title>Calendario</Title>
      <div className="flex justify-center items-center w-100  ">
        <div className="max-w-7xl mx-auto bg-gray-blue">
          <Calendar
            localizer={localizer}
            events={events}
            components={{
              toolbar: CustomToolbar,
            }}
            startAccessor="start"
            endAccessor="end"
            style={{
              width: "70vw",
              height: "80vh",
            }}
            views={["month"]}
          />
        </div>
      </div>
    </div>
  );
};

export default MyCalendar;
