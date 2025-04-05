using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class FormulaMedica
    {
        public int IdFormulaMedica { get; set; }
        public int IdPaciente { get; set; }
        public List<String> NombreCitasMedicas { get; set; }
        public FormulaMedica() { }
        public FormulaMedica(int idFormulaMedica, int idPaciente, List<String> nombreCitasMedicas)
        {
            IdFormulaMedica = idFormulaMedica;
            IdPaciente = idPaciente;
            NombreCitasMedicas = nombreCitasMedicas;
        }
    }
}
