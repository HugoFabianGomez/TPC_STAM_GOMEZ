using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marcas
    {
        public Marcas() { }

        public int idMarcas { get; set; }
        public string nombreMarcas { get; set; }


        public void setId(int id)
        {
            idMarcas = id;
        }
        public Marcas(string descripcion)
        {
            nombreMarcas = descripcion;
        }

        public Marcas(int id)
        {
            idMarcas = id;
        }

        public Marcas(int id, string nombre)
        {
            idMarcas = id;
            nombreMarcas = nombre;
        }

        public string getNombreMarca()
        {
            return nombreMarcas;
        }
        public override string ToString()
        {
            return nombreMarcas;
        }
    }
}
