using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Models
{
    class Commentaire
    {
        public int CommentaireId { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
