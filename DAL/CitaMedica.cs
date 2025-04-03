using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CitaMedica
    {
        public int IdCita { get; set; }
        public string TipoConsulta { get; set; }
        public HorarioCitaMedica horarioCitaMedica { get; set; }

        public CitaMedica() { }
        public CitaMedica(int idCita, string tipoConsulta, HorarioCitaMedica horarioCitaMedica)
        {
            IdCita = idCita;
            TipoConsulta = tipoConsulta;
            this.horarioCitaMedica = horarioCitaMedica;
        }

    }

}
