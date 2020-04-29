using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class DetallesCompras
    {
            public int Compraid { get; set; }
            public Compra compra { get; set; }

            public int Productoid { get; set; }
            public Producto producto { get; set; }

            public decimal Precio { get; set; }
            public int Cantidad { get; set; }

            public decimal Total { get; set; }
        
    }
}
