using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEvenement
{
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            
            Navigation.RemovePage(new MainPage());
             Detail = new TabbedPage
                 {

                     Children =
                     {
                          new Day1(),
                          new Day2(),
                          new Day3(),

                     }

                 };
                 
        }
        private void AllerL(object sender, EventArgs e)
        {



            Detail = new NavigationPage(new MainPage());
        }
        public void AllerA(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Day2());
        }
        public void AllerR(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Day3());
        }


    }
}
