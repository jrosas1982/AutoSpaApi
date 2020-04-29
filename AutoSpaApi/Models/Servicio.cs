using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Servicio
    {
        public int id { get; set; } 
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public IList<DetallesReserva> detalle { get; set; }
    }
}
