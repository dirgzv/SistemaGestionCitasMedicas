using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Clinica : EntidadSalud
    {
        public int IdClinica { get; set; }
        public int IdUsuario { get; set; }
        public List<Medico> Medicos { get; set; }
        public List<Paciente> Pacientes { get; set; }
        public Clinica() { }
        public Clinica(int idEntidadSalud, string nombre, string telefono, string correo, string direccion, int idClinica, int idUsuario)
            : base(idEntidadSalud, nombre, telefono, correo, direccion)
        {
            IdClinica = idClinica;
            IdUsuario = idUsuario;
            Medicos = new List<Medico>();
            Pacientes = new List<Paciente>();
        }
    }
}
