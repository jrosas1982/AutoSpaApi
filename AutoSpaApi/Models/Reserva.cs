using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Reserva
    {
        public int id { get; set; }
        public decimal precio { get; set; }
        public bool pagado { get; set; }
        public int Usuarioid { get; set; }
        public Usuario usuario { get; set; }
        public IList<DetallesReserva> detalle { get; set; }

        //incluir taller 
    }
}
