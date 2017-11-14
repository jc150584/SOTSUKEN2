using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Plugin.Media;
using Plugin.Media.Abstractions;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        public EntryPage(string title)
        {
            //タイトル
            Title = title;

            //初期化
            InitializeComponent();

            // ボタンが押された時の処理は、asyncメソッドの中で実行する必要があるので、
            // XAMLの中にclickedは書けないんじゃないかと思うけどどうなんだろ
            PictureButton.Clicked += takePicture;

        }
        void SelectSwitch(object sender, ToggledEventArgs args)
        {
            //保存食品
            if (args.Value)
            {
                FoodPicker.IsEnabled = false;
                NumEntry.IsEnabled = true;
                UnitEntry.IsEnabled = true;

            }
            //食材
            else
            {
                NumEntry.IsEnabled = false;
                UnitEntry.IsEnabled = false;
                FoodPicker.IsEnabled = true;
            }
        }

        async void takePicture(object sender, EventArgs e)
        // from https://github.com/jamesmontemagno/MediaPlugin
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera available.", "OK");
                return;
            }

            StoreCameraMediaOptions cameraOption = new StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            };
            var file = await CrossMedia.Current.TakePhotoAsync(cameraOption);

            if (file == null)
                return;

            await DisplayAlert("File Location", file.Path, "OK");

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });

            //or:
            //image.Source = ImageSource.FromFile(file.Path);
            //image.Dispose();
        }

    }
}