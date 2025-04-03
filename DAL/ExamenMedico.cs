using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExamenMedico
    {
        public int IdExamenMedico { get; set; }
        public string Analisis { get; set; }
        public string Descripcion { get; set; }
        public ExamenMedico() { }
        public ExamenMedico(int idExamenMedico, string analisis, string descripcion)
        {
            IdExamenMedico = idExamenMedico;
            Analisis = analisis;
            Descripcion = descripcion;
        }
    }
}
