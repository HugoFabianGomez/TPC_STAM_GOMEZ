using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Marcas
    {
        public int idMarcas { get; set; }
        public string nombreMarcas { get; set; }
        public Marcas(string descripcion)
        {

            nombreMarcas = descripcion;
        }

        public Marcas(int id, string descripcion)
        {
            idMarcas = id;
            nombreMarcas = descripcion;
        }
    }
}
