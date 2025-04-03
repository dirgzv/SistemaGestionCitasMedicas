using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Usuario : Persona
        {
            public string NombreUsuario { get; set; }
            public string Contrasena { get; set; }
            public Clinica clinica { get; set; }
            public Usuario() { }
            public Usuario(int idPersona, string nombre, string apellido, char sexo, DateTime fechaNacimiento, string telefono, string correo, string direccion, string nombreUsuario, string contrasena,Clinica clinica)
                : base(idPersona, nombre, apellido, sexo, fechaNacimiento, telefono, correo, direccion)
            {
                NombreUsuario = nombreUsuario;
                Contrasena = contrasena;
                this.clinica = clinica;
            }
    }
}
