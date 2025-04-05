using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistoriaClinica
    {
        public int IdHistoriaClinica { get; set; }
        public int IdPaciente { get; set; }
        public string MotivoConsulta { get; set; }
        public string Descripcion { get; set; }
        public string Evolucion { get; set; }
        public string CausaExterna { get; set; }
        public SignosVitales SignosVitales { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public ExamenFisico ExamenFisico { get; set; }
        public HistoriaClinica() { }
        public HistoriaClinica(int idHistoriaClinica, int idPaciente, string motivoConsulta, string descripcion, string evolucion, string causaExterna, SignosVitales signosVitales, Diagnostico diagnostico, ExamenFisico examenFisico)
        {
            IdHistoriaClinica = idHistoriaClinica;
            IdPaciente = idPaciente;
            MotivoConsulta = motivoConsulta;
            Descripcion = descripcion;
            Evolucion = evolucion;
            CausaExterna = causaExterna;
            SignosVitales = signosVitales;
            Diagnostico = diagnostico;
            ExamenFisico = examenFisico;
        }
    }
}
