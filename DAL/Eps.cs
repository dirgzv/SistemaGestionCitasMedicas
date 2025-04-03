using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Clinica : Eps
    {
        public Clinica() { }
        public Clinica(int idEntidadSalud, string nombre, string telefono, string direccion)
            : base(idEntidadSalud, nombre, telefono, direccion)
        {
        }
    }
}


