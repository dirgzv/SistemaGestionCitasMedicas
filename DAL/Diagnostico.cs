using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Diagnostico
    {
        public int IdDiagnostico { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public Diagnostico() { }
        public Diagnostico(int idDiagnostico, string tipo, string descripcion)
        {
            IdDiagnostico = idDiagnostico;
            Tipo = tipo;
            Descripcion = descripcion;
        }
    }
}
