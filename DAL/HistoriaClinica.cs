using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HistoriaClinica
    {
        public int IdHistoriaClinica { get; set; }
        public string MotivoConsulta { get; set; }
        public string Descripcion { get; set; }
        public string Antecedentes { get; set; }
        public string Evolucion { get; set; }
        public Diagnostico diagnostico { get; set; }
        public ExamenMedico examenMedico { get; set; }
        public SignosVitales signosVitales { get; set; }
        public HistoriaClinica() { }
        public HistoriaClinica(int idHistoriaClinica, string motivoConsulta, string descripcion, string antecedentes, string evolucion, Diagnostico diagnostico, ExamenMedico examenMedico, SignosVitales signosVitales)
        {
            IdHistoriaClinica = idHistoriaClinica;
            MotivoConsulta = motivoConsulta;
            Descripcion = descripcion;
            Antecedentes = antecedentes;
            Evolucion = evolucion;
            this.diagnostico = diagnostico;
            this.examenMedico = examenMedico;
            this.signosVitales = signosVitales;
        }
    }
}
