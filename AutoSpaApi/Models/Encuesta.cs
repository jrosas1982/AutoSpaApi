using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoSpaApi.Models
{
    public class Encuesta
    {
       public int id { get; set; }
       public string preguntas { get; set; }
       public string tipo_encuesta { get; set; }
       public List<EncuestaPorUsuario> encuestaPorUsuarios { get; set; }

    }
}
