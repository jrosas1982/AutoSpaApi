using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Consulta
    {
        public int id { get; set; }
        public string tiutlo { get; set; }
        public string consulta { get; set; }
        public int Usuarioid { get; set; }
        public Usuario usuario { get; set; }
        public int UsuarioSoporteId { get; set; }
    }
}
