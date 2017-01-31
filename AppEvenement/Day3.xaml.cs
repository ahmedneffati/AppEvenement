using AppEvenement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEvenement
{
    public partial class Day3 : ContentPage
    {
        public Day3()
        {
            InitializeComponent();
            getTaches();
        }
        public async void getTaches()
        {
            var tachS = new TacheServices();
            var Taches = new List<Models.Tache>();
            Taches = await tachS.getTachesOfDayAsync(3);
            list.ItemsSource = Taches;
            /*  foreach(var Tache in Taches)
              {
                  var t = Tache;
              }
              */

        }
    }
}