using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HorarioCitaMedica : Horario
    {
        public DateTime Fecha;
        public HorarioCitaMedica() { }
        public HorarioCitaMedica(int idHorario, DateTime horaInicio, DateTime horaFin, DateTime fecha)
            : base(idHorario, horaInicio, horaFin)
        {
            Fecha = fecha;
        }


    }
}
