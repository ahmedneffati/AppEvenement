using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEvenement
{
    public partial class DetailTache : ContentPage
    {
        public DetailTache()
        {
            InitializeComponent();
        }
        public DetailTache(Models.Post t)
        {
            
            InitializeComponent();
            title.Text = t.Title;
            desc.Text = t.Date.ToString();
            a.Source = ImageSource.FromUri(new Uri(t.ImageUrl));
            
        }   
    }
}
