using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.Models
{
   public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }

        public double attitude { get; set; }
        public double longitude { get; set; }

        public int UserId { get; set; }
        public int CategorieId { get; set; }
    }
}
