using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class EntidadSalud
    {
        public int IdEntidadSalud { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public EntidadSalud() { }
        public EntidadSalud(int idEntidadSalud, string nombre, string telefono, string correo, string direccion)
        {
            IdEntidadSalud = idEntidadSalud;
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
            Direccion = direccion;
        }
    }
}
