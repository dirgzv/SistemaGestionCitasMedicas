using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario : Persona
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int IdUsuario { get; set; }
        public Clinica Clinica { get; set; }
        public Usuario() { }
        public Usuario(int idPersona, string nombre, string apellido, char sexo, int edad, string telefono, string correo, string direccion, DateTime fechaNacimiento, string nombreUsuario, string contrasena, int idUsuario, Clinica clinica)
            : base(idPersona, nombre, apellido, sexo, edad, telefono, correo, direccion, fechaNacimiento)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            IdUsuario = idUsuario;
            Clinica = clinica;
        }
    }
}
