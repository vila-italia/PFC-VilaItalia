using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VilaItalia.Models
{
    public class Balcao
    {
        public int BalcaoId { get; set; }
        public int? ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public virtual ICollection<FichaTecnica> FichaTecnicas { get; set; }


    }
}