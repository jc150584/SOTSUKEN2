using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodStock01;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage1 : ContentPage
    {
        ObservableCollection<ButtonAndString> myAL;
        String s = "http://cookpad.com/search/";

        public FoodPage1(string title)
        {

            //タイトル
            Title = title;

            //アイコン
            Icon = "apple32.png";


            InitializeComponent();

           /* myAL =
               new ObservableCollection<ButtonAndString>();*/

        }

        /*void ChackBoxChanged(object sender, bool isChecked)
        {
            //選択された時の処理
            if (isChecked)
            { 

       
            }
            //選択が外された時の処理
            else
            {
               
            }
        }*/

        void OnButtonClicked(object sender, EventArgs e)
        {
            //myAL.Add(new ButtonAndString { B = (Button)sender, S = ((Button)sender).Text});

            s += ((Button)sender).Text + "　";
            DisplayAlert("URL", s, "ok");

            //myALの中に入ってたらボタンのテキストをアラート表示
            /* foreach (ButtonAndString bas in myAL)
             {
                 if ((Button)sender == (bas.B))
                 {
                     s = "http://cookpad.com/search/" + bas.S;
                     break;
                 }*/
            //DisplayAlert("ButtonAndString", s, "ok");
            // }
            /* var Recipe = new WebView
             {
                 Source = s
             };
             Content = Recipe;*/
        }

        public class ButtonAndString
        {
            public Button B { set; get; }
            public String S { set; get; }
        }

        void OnSearch_Clicked(object sender, EventArgs args)
        {
            var Recipe = new WebView
            {
                Source = "\"" +s+ "\""
            };
            Content = Recipe;

            //Application.Current.MainPage = new RecipePage("レシピ");
        }
    }
}