using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Categoria
    {
        public int id { get; set; }
        [Required]
        [Display(Name = "Nombre de Categoría")]
        public string nombreCategoria { get; set; }

    }
}
