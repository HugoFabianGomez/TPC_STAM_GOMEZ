using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Clientes
    {
        public string cuit { get; set; }
        public string razonSocial { get; set; }
        public string contacto { get; set; }
        public string domicilio { get; set; }
        public string localidad { get; set; }
        public string provincia { get; set; }
        public Clientes(string Cuit, string RazonSocial)
        {
            cuit = Cuit;
            razonSocial = RazonSocial;
        }
    }
}
