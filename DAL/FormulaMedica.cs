using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FormulaCitaMedica 
    {
        public int IdFormulaCitaMedica { get; set; }
        public string MotivoConsulta { get; set; }
        public string Descripcion { get; set; }
        public Diagnostico Diagnostico { get; set; }
        public List<String> NombreCitas { get; set; } = new List<String>();
        public FormulaCitaMedica() { }
        public FormulaCitaMedica(int idFormulaCitaMedica, string motivoConsulta, string descripcion, Diagnostico diagnostico, List<String> nombreCitas)
        {
            IdFormulaCitaMedica = idFormulaCitaMedica;
            MotivoConsulta = motivoConsulta;
            Descripcion = descripcion;
            Diagnostico = diagnostico;
            NombreCitas = nombreCitas;
        }
    }
}
