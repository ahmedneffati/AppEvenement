using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEvenement
{
    public partial class Connection : ContentPage
    {
        public Connection()
        {
            InitializeComponent();
        }
        private async void Button_ClickedAsync(object sender, EventArgs e)
        {


            try
            {

                //http://takwira.azurewebsites.net/api/Joueurs/Connexion/azdadz/huuih
                string Url = string.Format("http://takwira.azurewebsites.net/api/Joueurs/Connexion/" + email.Text.ToString() + "/" + pass.Text.ToString());
                HttpClient client = new HttpClient();
                string json = await client.GetStringAsync(Url);
                // Joueur utilisateur = JsonConvert.DeserializeObject<Joueur>(json);
                if (json.Length > 20)
                    email.Text = "";
                pass.Text = "";
                await Navigation.PushAsync(new Menu());

                // await Navigation.RemovePage(Connexion);
            }
            catch (Exception ex)
            {

            }





        }

        private async void Button_ClickedAsync2(object sender, EventArgs e)
        {


            await Navigation.PushAsync(new Inscription());



        }
        private async void ButtRec(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new HelpAccount());
        }
    }
}