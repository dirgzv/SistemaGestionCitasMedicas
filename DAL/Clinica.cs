using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Clinica : EntidadSalud
    {
        public List<Medico> Medicos { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public Clinica() { }
        public Clinica(int idEntidadSalud, string nombre, string telefono, string direccion)
            : base(idEntidadSalud, nombre, telefono, direccion)
        {
        }
    }
}

