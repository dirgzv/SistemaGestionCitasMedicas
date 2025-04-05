using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Diagnostico
    {
        public int IdDiagnostico { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Antecedentes { get; set; }
        public int IdHistoriaClinica { get; set; }
        public Diagnostico() { }
        public Diagnostico(int idDiagnostico, string tipo, string descripcion, string antecedentes, int idHistoriaClinica)
        {
            IdDiagnostico = idDiagnostico;
            Tipo = tipo;
            Descripcion = descripcion;
            Antecedentes = antecedentes;
            IdHistoriaClinica = idHistoriaClinica;
        }
    }

}
