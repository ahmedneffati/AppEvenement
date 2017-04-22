using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppEvenement
{
    public partial class Add : ContentPage
    {
        public Add()
        {
            InitializeComponent();
        }
        private MediaFile _mediaFile;
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var answer = await DisplayAlert("صورة", "اضافة صورة ", "التقط صورة", "اجلب صورة");
            await CrossMedia.Current.Initialize();
            if (answer)
            {

                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("لا يوجد كمرة", ":( كمرة ليسة مسموحة", "lموافق");
                    return;
                }
                _mediaFile = await CrossMedia.Current.PickPhotoAsync();
                if (_mediaFile == null)
                {
                    return;
                }
                x.Source = ImageSource.FromStream(() =>
                {
                    return _mediaFile.GetStream();
                });
                await DisplayAlert("good", _mediaFile.Path, "Ok");
            }

            else
            {
                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    await DisplayAlert("Error", ":( No Take Photo available", "OK");
                    return;
                }
                _mediaFile = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "sample",
                    Name = "myImage.jpg"
                });
                if (_mediaFile == null)
                    return;
                await DisplayAlert("good", _mediaFile.Path, "Ok");
                x.Source = ImageSource.FromStream(() =>
                {
                    return _mediaFile.GetStream();
                });


            }
        }
        }
}
