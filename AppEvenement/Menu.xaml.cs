using AppEvenement.Models;
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

            tret();
            //  Navigation.RemovePage(new MainPage());

            //  Detail.BindingContext = new Day1();
           
            //https://forums.xamarin.com/discussion/18244/programmatically-switch-between-tabs-in-a-tabbedpage


            
               listView.ItemsSource = new List<lis> { new lis("دخول", "ic_email_3x.png"), new lis("استقبال اخر المستجدات", "ic_email_3x.png"), new lis("اضافة", "ic_email_3x.png"), new lis("استقبال اخر المستجدات", "ic_email_3x.png"), new lis("تغيير صوت اللاقط", "ic_email_3x.png") };
            // listView.HorizontalOptions = Xamarin.Forms.LayoutOptions.End; ;

            // Detail.Focused;
           
            listView.ItemTapped += async (sender, args) =>
              {
                  
                 var item = args.Item as lis;
                  
                if (item.Title.Equals("دخول"))
                
                  await Navigation.PushAsync(new Connection());
                else
                      
                if (item.Title.Equals("اضافة"))

                      await Navigation.PushAsync(new Add());
                  if (item.Title.Equals("الدهاب الى صثؤ صؤث صث"))
                      await Navigation.PushAsync(new Day2());
                  else
                      if (item.Title.Equals("الدهاب الى صثب صث صثؤ صؤ صؤث"))
                      await Navigation.PushAsync(new Day2());
                  if (item.Title.Equals("تغيير صوت اللاقط"))
                      await Navigation.PushAsync(new son());
                  if (item.Title.Equals("استقبال اخر المستجدات"))
                      await Navigation.PushAsync(new AddMail());
                  
              };
         
        }
        
        public async void tret()
        {
            try
            {
                Detail = new TabbedPage
                {

                    Children =
                     {
                        new Day3(),
                        new Day2(),

                        new Day1(),


                     }


                };

                var tabbed = Detail as TabbedPage;
                tabbed.CurrentPage = tabbed.Children[2];
                
            }
            catch (Exception e)
            {
              
               // await DisplayAlert("خطا", "شغل الانترنات", "Ok");
            }
        }
           private void AllerL(object sender, EventArgs e)
           {



               Detail = new NavigationPage(new MainPage());
           }
           public void AllerA(object sender, EventArgs e)
           {
               Detail = new NavigationPage(new Day2());
           }
           public async void AllerR(object sender, EventArgs e)
           {
               await Navigation.PushAsync(new Day3());
           }

           private async void ImageCell_Tapped(object sender, EventArgs e)
           {
               ImageCell s= sender as ImageCell;
               if (s.Text.Equals("cccc"))
               {
                   await Navigation.PushAsync(new Day3());
               }
               else if(s.Text.Equals("bbbb"))
               {
                   await Navigation.PushAsync(new Day2());
               }
               else
                   await Navigation.PushAsync(new Day1());
           }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
          new Menu();
        }
        private void ToolbarItem_Clicked2(object sender, EventArgs e)
        {
            if (ss.IsDestructive == true)
                ss.IsDestructive = false;
            else ss.IsDestructive = true;
                    
        }
       
    }
    public class lis
       {
           public string Title { get; set; }
           public string IconSource { get; set; }
           public lis(string tit, string Imag)
           {
               Title = tit;
               IconSource = Imag;
           }
       
        
    }
   
         

}