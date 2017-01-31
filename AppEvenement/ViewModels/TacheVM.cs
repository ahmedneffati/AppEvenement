using AppEvenement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEvenement.ViewModels
{
    class TacheVM
    {
        TacheServices u = new TacheServices();
        private List<Models.Tache> _TachesList;
        public List<Models.Tache> TachesList
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
        public TacheVM()
        {
            getdata();
            
        }
        public async void getdata()
        {
            var tachS = new TacheServices();
            TachesList = await tachS.getTachesOfDayAsync(1);
        }
    }
}
