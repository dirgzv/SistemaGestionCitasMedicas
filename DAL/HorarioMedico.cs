using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HorarioMedico : Horario
    {
        public override TimeSpan HoraInicio { get; }
        public override TimeSpan HoraFin { get; }

        public HorarioMedico(TimeSpan inicio, TimeSpan fin)
        {
            HoraInicio = inicio;
            HoraFin = fin;
        }
    }

}
