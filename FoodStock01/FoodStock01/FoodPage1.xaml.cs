using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage1 : ContentPage
    {
        public FoodPage1(string title)
        {

            //タイトル
            Title = title;

            //アイコン
            Icon = "apple32.png";


            InitializeComponent();

            /*var ar = new ObservableCollection<String>();
            ar.Add(string.Format("ばなな"+"\t"+"4"+"日"+"\u2610"));
            ar.Add(string.Format("にんじん" + "\t" + "5" + "日" + "\u2610"));
            ar.Add(string.Format("とまと" + "\t" + "3" + "日" + "\u2610"));
            ar.Add(string.Format("ぴーまん" + "\t" + "7" + "日" + "\u2610"));


            // リストビューを生成する
            var listView = new ListView
            {
                ItemsSource = ar,
                RowHeight = 50
            };

            var label1 = new Label
            {
                Text = "食品リスト",
                TextColor = Color.DodgerBlue,
                BackgroundColor = Color.Transparent
            };


            Content = new StackLayout
            { 
                Padding = new Thickness(20, 30, 20, 0), 
                Children = { label1, listView }
            };*/

        }

        private void Search_Clicked(object sender, EventArgs e)
        { 
            //webview生成
            var webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://cookpad.com/",
                },
            };
            //コンテンツとして配置
            Content = webView;
        }

        void ChackBoxChanged(object sender, bool isChecked)
        {
            //選択された時の処理
            if (isChecked)
            {
                
            }
            //選択が外された時の処理
            else
            {
               
            }
        }
    }
}