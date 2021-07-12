using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Presentacion
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public Presentacion(string Descripcion)
        {
            descripcion = Descripcion;
        }
        public Presentacion(int Id, string Descripcion)
        {
            id = Id;
            descripcion = Descripcion;
        }
    }
}
