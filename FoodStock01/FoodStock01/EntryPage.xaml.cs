using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Plugin.Media;
using Plugin.Media.Abstractions;

using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

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

            image.Source = Xamarin.Forms.ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });

            //or:
            //image.Source = ImageSource.FromFile(file.Path);
            //image.Dispose();



        }



        //登録ボタンが押された処理
        void EntryButton_Clicked()
        {

        }

        private void testcode01(MediaFile file)
        {
            var img = System.Drawing.Image.FromFile(file.Path);
            BitmapData bmpData = img.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] pixels = new byte[img.Width * img.Height * 4];
            Marshal.Copy(bmpData.Scan0, pixels, 0, pixels.Length);

            //Base64で文字列に変換
            string base64String;
            base64String = System.Convert.ToBase64String(bs);

            //結果表示
            EncoBase64.Text = base64String.ToString();
        }

        private void testcode03()
        {
            ImageConverter imgconv = new ImageConverter();
            //imageをバイト配列に変換
            byte[] b = (byte[])imgconv.ConvertTo(image, typeof(byte[]));

            //Base64で文字列に変換
            string base64String;
            base64String = System.Convert.ToBase64String(b);

            //結果表示
            EncoBase64.Text = base64String.ToString();
        }

        private void testcode02(MediaFile file)
        {
            ////////////////////////////////
            //delete me
            //////////////////////////////////

            Stream stream = file.GetStream();


            //エンコード
            int width = 128;
            int height = width;
            int stride = width / 8;
            byte[] pixels = new byte[height * stride];

            // イメージパレットを定義
            BitmapPalette myPalette = BitmapPalettes.Halftone256;

            // あらかじめ定義されたパレットで新しい空のイメージを作成
            BitmapSource image2 = BitmapSource.Create(
            width,      //幅
            height,    //高さ
            96,         //水平(dpi)
            96,         //垂直(dpi)
            PixelFormats.Indexed1, //ピクセル形式
            myPalette,  //パレット
            pixels,     //イメージのコンテンツを表すバイト配列
            stride);    //stride

            FileStream stream2 = new FileStream(file.Path, FileMode.Create);　      //パス名、ファイルを作成する方法
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();                    //JPEG形式のイメージのエンコーダー定義
            TextBlock myTextBlock = new TextBlock();
            myTextBlock.Text = "Codec Author is: " + encoder.CodecInfo.Author.ToString();
            encoder.FlipHorizontal = true;                                          //エンコード時にイメージを水平方向に反転
            encoder.FlipVertical = false;                                           //エンコード時にイメージを垂直方向に反転させない
            encoder.QualityLevel = 30;                                              //品質レベル　1～100
            encoder.Rotation = Rotation.Rotate90;                                   //イメージを回転
            encoder.Frames.Add(BitmapFrame.Create(image2));                         //image2のフレーム設定
            encoder.Save(stream2);                                                  //stream2にエンコード

            //エンコ結果表示
            EncoBase64.Text = encoder.ToString();
        }

    }
}