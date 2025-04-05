using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CitaMedica
    {
        public int IdCita { get; set; }
        public string Nombre { get; set; }
        public int IdMedico { get; set; }

        public int IdPaciente { get; set; }
        public HorarioCitaMedica Horario { get; set; }
        public string Estado { get; set; }
        public CitaMedica() { }
        public CitaMedica(int idCita, string nombre, int idMedico, int idPaciente, HorarioCitaMedica horario, string estado)
        {
            IdCita = idCita;
            Nombre = nombre;
            IdMedico = idMedico;
            IdPaciente = idPaciente;
            Horario = horario;
            Estado = estado;
        }
    }

}
