using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Stock: Producto
    {
        public int idStock { get; set; }
        public Producto idproducto { get; set; }
        public DateTime fecha_Ingreso { get; set; }
        public int cantidadIngresada { get; set; }
        public int stock { get; set; }
    }
}
