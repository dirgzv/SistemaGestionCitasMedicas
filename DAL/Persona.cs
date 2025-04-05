using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Sexo { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona() { }
        public Persona(int idPersona, string nombre, string apellido, char sexo, int edad, string telefono, string correo, string direccion, DateTime fechaNacimiento)
        {
            IdPersona = idPersona;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Edad = edad;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
        }
    }
}
