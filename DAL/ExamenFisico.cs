using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ExamenFisico
    {
        public int IdExamenFisicoPaciente { get; set; }
        public string Analisis { get; set; }
        public string Abdomen { get; set; }
        public string CabezaCuelloCara { get; set; }
        public string SistemaNervioso { get; set; }
        public string Cardiopulmonar { get; set; }
        public string Genitourinario { get; set; }
        public string Extremidades { get; set; }
        public string PielFaneras { get; set; }
        public string Descripcion { get; set; }
        public int IdHistoriaClinica { get; set; }
        public ExamenFisico() { }
        public ExamenFisico(int idExamenFisicoPaciente, string analisis, string abdomen, string cabezaCuelloCara, string sistemaNervioso, string cardiopulmonar, string genitourinario, string extremidades, string pielFaneras, string descripcion, int idHistoriaClinica)
        {
            IdExamenFisicoPaciente = idExamenFisicoPaciente;
            Analisis = analisis;
            Abdomen = abdomen;
            CabezaCuelloCara = cabezaCuelloCara;
            SistemaNervioso = sistemaNervioso;
            Cardiopulmonar = cardiopulmonar;
            Genitourinario = genitourinario;
            Extremidades = extremidades;
            PielFaneras = pielFaneras;
            Descripcion = descripcion;
            IdHistoriaClinica = idHistoriaClinica;
        }
    }

}
