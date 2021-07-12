using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Producto
    {
        public int id { get; set; }
        public Marcas marcas { get; set; }
        public Categorias categorias { get; set; }
        public Presentacion presentacion { get; set; }
        public string descripcion { get; set; }
        public float peso { get; set; }
        public Decimal precioUnitario { get; set; }
        public string urlImagen { get; set; }
        public float estado { get; set; }
    }
}
