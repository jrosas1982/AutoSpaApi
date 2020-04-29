using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Perfil
    {
        public int id { get; set; }

        public string titular_tarjeta { get; set; }
       
        public string num_tarjeta { get; set; }
        
        public string datos_vehiculos { get; set; }
       //public List<Servicios> preferencias { get; set, }

        public int Usuarioid { get; set; }

    }
}

