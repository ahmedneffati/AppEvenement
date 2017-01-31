using AppEvenement.Models;
using AppEvenement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEvenement
{
    public partial class Day1 : ContentPage
    {
        
        public Day1()
        {
            InitializeComponent();
           getTaches();
        }
        public async void getTaches()
        {
           var tachS = new TacheServices();
           var Taches = new List<Tache>();
            Taches = await  tachS.getTachesOfDayAsync(1);
            list.ItemsSource = Taches;
          /*  foreach(var Tache in Taches)
            {
                var t = Tache;
            }
            */

        }
    }
}
