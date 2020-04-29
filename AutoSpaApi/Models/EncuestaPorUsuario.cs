using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class EncuestaPorUsuario
    {
        public int Encuestaid { get; set; }
        
        public int Usuarioid { get; set; }

        public Encuesta encuesta { get; set; }

        public Usuario usuario { get; set;}

    }
}
