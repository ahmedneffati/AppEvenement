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
    public partial class Day3 : ContentPage
    {
        public Day3()
        {
            InitializeComponent();
            getTaches();
            
         

        }
        public async void getTaches()
        {

            try
            {
                var tachS = new PostServices();
                var Taches = new List<Post>();
                Taches = await tachS.getTachesOfDayAsync(3);
                list.ItemsSource = Taches;
                Post p = new Post();
               
                
                list.ItemTapped += async (sender, args) =>
                {
                    var item = args.Item as Post;
                    if (item == null) return;
                    await Navigation.PushAsync(new DetailTache(item));
                    list.SelectedItem = null;
                    
                };
            }
            catch (Exception)
            {
                await DisplayAlert("خطا", "شغل الانترنات", "Ok");
            }
        }
    }


}