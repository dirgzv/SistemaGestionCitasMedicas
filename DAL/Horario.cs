using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Horario
    {
        public int IdHorario { get; set; }
        public abstract TimeSpan HoraInicio { get; }
        public abstract TimeSpan HoraFin { get; }

        public Horario() { }
        public Horario(int idHorario)
        {
            IdHorario = idHorario;
        }
    }
}


