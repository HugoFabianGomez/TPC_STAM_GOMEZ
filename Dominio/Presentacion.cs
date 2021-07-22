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

        public Presentacion() { }
        public string descripcion { get; set; }

        public Presentacion(int idPresentaciones)
        {
            id = idPresentaciones;
        }
        public Presentacion(string Descripcion)
        {
            descripcion = Descripcion;
        }
        public Presentacion(int Id, string Descripcion)
        {
            id = Id;
            descripcion = Descripcion;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public int getId()
        {
            return id;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}
