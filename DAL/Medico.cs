using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Medico : Persona
    {
        public int IdMedico { get; set; }
        public string Especialidad { get; set; }
        public List<HorarioMedico> Horarios { get; set; } = new List<HorarioMedico>();
        public Medico() { }
        public Medico(int idPersona, string nombre, string apellido, char sexo, DateTime fechaNacimiento, string telefono, string correo, string direccion, int idMedico, string especialidad, List<HorarioMedico> horarios)
            : base(idPersona, nombre, apellido, sexo, fechaNacimiento, telefono, correo, direccion)
        {
            IdMedico = idMedico;
            Especialidad = especialidad;
            Horarios = horarios;
        }
    }
}


