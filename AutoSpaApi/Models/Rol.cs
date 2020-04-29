using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Rol
    {
        public int id { get; set; }

        public string descripcion { get; set; }

        public int Usuarioid { get; set; }
    }
}
