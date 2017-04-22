using AppEvenement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.ViewModels
{
    class PostVM
    {
        PostServices u = new PostServices();
        private List<Models.Post> _TachesList;
        public List<Models.Post> TachesList
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
        public PostVM()
        {
            getdata();

        }
        public async void getdata()
        {
            var tachS = new PostServices();
            TachesList = await tachS.getTachesOfDayAsync(1);
        }
    }
}
