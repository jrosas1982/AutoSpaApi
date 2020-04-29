using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Usuario
    {
        public int id { get; set; }

        public string nombre { get; set; }
       
        public string apellido { get; set; }  
     
        public string dni { get; set; }
       
        public DateTime fechaNac { get; set; }
      
        public string email { get; set; }

        public string pass { get; set; }
        
        public Perfil perfil { get; set; }
        
        public Rol rol { get; set; }

        public List<EncuestaPorUsuario> encuestaPorUsuarios { get; set; }

        public List<Compra> compraPorCliente { get; set; }

        public List<Consulta> consultasPorCliente { get; set; }

        public int referenteid { get; set; }
    }
}
