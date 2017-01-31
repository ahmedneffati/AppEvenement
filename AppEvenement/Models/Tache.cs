using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Models
{
    class Tache
    {
        public long Id { get; set; }
        public string Debut { get; set; }
        public string Fin { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public long EvenementId { get; set; }
    }
}
