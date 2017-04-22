using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEvenement
{
    public partial class HelpAccount : ContentPage
    {
        public HelpAccount()
        {
            InitializeComponent();
        }
        private async void send(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Connection());
        }
    }
}
