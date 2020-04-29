using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Producto
    {
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        public string descipcion { get; set; }
        public decimal precio { get; set; }
        public int categoriasid { get; set; }
        public Categoria categorias { get; set; }
        public List<DetallesCompras> detalleCompra { get; set; }
        //public string tamaño { get; set; }

    }

}
