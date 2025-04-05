using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Medico : Persona
    {
        public int IdMedico { get; set; }
        public int IdClinica { get; set; }
        public string Especialidad { get; set; }
        public HorarioMedico Horario { get; set; }
        public List<CitaMedica> CitaMedicas  { get; set; } = new List<CitaMedica>();
        public List<HorarioCitaMedica> CitasProgramadas { get; set; } = new List<HorarioCitaMedica>();
        public Medico() { }
        public Medico(int idPersona, string nombre, string apellido, char sexo, int edad, string telefono, string correo, string direccion, DateTime fechaNacimiento, int idMedico, string especialidad, HorarioMedico horario, List<CitaMedica> citaMedicas, List<HorarioCitaMedica> citasProgramadas, int idClinica)
            : base(idPersona, nombre, apellido, sexo, edad, telefono, correo, direccion, fechaNacimiento)
        {
            IdMedico = idMedico;
            Especialidad = especialidad;
            Horario = horario;
            CitaMedicas = citaMedicas;
            CitasProgramadas = citasProgramadas;
            IdClinica = idClinica;
        }
    }
}
