using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class DetallesReserva
    {
        public int Reservaid { get; set; }
        public Reserva reserva { get; set; }

        public int Servicioid { get; set; }
        public Servicio servicio { get; set; }

        public decimal precioServicio { get; set; }

        public DateTime turno { get; set; }
    }
}
