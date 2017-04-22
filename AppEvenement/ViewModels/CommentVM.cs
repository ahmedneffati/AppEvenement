using AppEvenement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.ViewModels
{
    class CommentVM
    {
        CommentServices u = new CommentServices();
        private List<Models.Commentaire> _TachesList;
        public List<Models.Commentaire> TachesList
        {
            get
            {
                return _TachesList;
            }
            set
            {
                _TachesList = value;

            }
        }
        public CommentVM()
        {
            getdata();

        }
        public async void getdata()
        {
            var tachS = new CommentServices();
          //  TachesList = await tachS.getTachesOfDayAsync(1);
        }
    }
}
