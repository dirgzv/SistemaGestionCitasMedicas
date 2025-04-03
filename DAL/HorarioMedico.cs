using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HorarioMedico : Horario
    {
        public String DiaSemana { get; set; }
        public HorarioMedico() { }
        public HorarioMedico(int idHorario, DateTime horaInicio, DateTime horaFin, string diaSemana)
            : base(idHorario, horaInicio, horaFin)
        {
            DiaSemana = diaSemana;
        }
    }
}

