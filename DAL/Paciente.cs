using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Paciente : Persona
    {
        public int IdPaciente { get; set; }
        public Eps MiEps { get; set; }
        public List<CitaMedica> Citas { get; set; } = new List<CitaMedica>();
        public List<CitaMedica> Citas { get; set; } = new List<CitaMedica>();

        public Paciente() { }
        public Paciente(int idPersona, string nombre, string apellido, char sexo, DateTime fechaNacimiento, string telefono, string correo, string direccion, int idPaciente, Eps miEps, List<CitaMedica> citas)
            : base(idPersona, nombre, apellido, sexo, fechaNacimiento, telefono, correo, direccion)
        {
            IdPaciente = idPaciente;
            MiEps = miEps;
            Citas = citas;
        }
    }
}

