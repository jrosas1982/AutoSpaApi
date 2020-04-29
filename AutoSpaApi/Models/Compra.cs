using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Compra
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public decimal total { get; set; }

        public int Usuarioid { get; set; }
        public Usuario usuario { get; set; }

        public List<DetallesCompras> detalleCompra {get;set;}
        //public int Productoid { get; set; }

    }
}
