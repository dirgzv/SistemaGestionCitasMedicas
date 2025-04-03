using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Persona() { }
        public Persona(int idPersona, string nombre, string apellido, char sexo, DateTime fechaNacimiento, string telefono, string correo, string direccion)
        {
            IdPersona = idPersona;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            FechaNacimiento = fechaNacimiento;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
