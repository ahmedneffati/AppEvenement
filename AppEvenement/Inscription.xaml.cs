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
    public partial class Inscription : ContentPage
    {
        public Inscription()
        {
            InitializeComponent();
        }
        private async void creer_Clicked(object sender, EventArgs e)
        {
            PostServices u = new PostServices();
            Post j = new Post();
            if (email.Text.Equals("") || pass.Text.Equals("") || pass.Text.Equals("") )
            {
                await DisplayAlert("Error", "there is atrebute is empty", "ok");
            }
            else
            {


                await Navigation.PushAsync(new Connection());
            }

        }
    }
}