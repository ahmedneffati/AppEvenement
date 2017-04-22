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
    public partial class Day2 : ContentPage
    {
        public Day2()
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
                Taches = await tachS.getTachesOfDayAsync(2);
                list.ItemsSource = Taches;
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