using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Horario
    {
        public int IdHorario { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public Horario() { }
        public Horario(int idHorario, DateTime horaInicio, DateTime horaFin)
        {
            IdHorario = idHorario;
            HoraInicio = horaInicio;
            HoraFin = horaFin;
        }

    }
}
