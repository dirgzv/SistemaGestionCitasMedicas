using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Eps : EntidadSalud
    {
        public int IdEps { get; set; }
        public Eps() { }
        public Eps(int idEntidadSalud, string nombre, string telefono, string correo, string direccion, int idEps)
            : base(idEntidadSalud, nombre, telefono, correo, direccion)
        {
            IdEps = idEps;
        }
    }
}
