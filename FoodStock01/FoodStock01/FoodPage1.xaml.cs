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

        public FoodPage1(string title)
        {

            //タイトル
            Title = title;

            //アイコン
            Icon = "apple32.png";


            InitializeComponent();

            myAL =
               new ObservableCollection<ButtonAndString>();

            myAL.Add(new ButtonAndString { B = b1, S = b1.Text });
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

            String s = "見つからないよ";
            foreach (ButtonAndString bas in myAL)
            {
                if ((Button)sender == (bas.B))
                {
                    s = bas.S;
                }
                DisplayAlert("ButtonAndString", s, "ok");
            }
        }

        public class ButtonAndString
        {
            public Button B { set; get; }
            public String S { set; get; }
        }

        /*void OnSearch_Clicked(object sender, EventArgs args)
        {
            var Recipe = new WebView
            {
                Source = "http://cookpad.com/search/"
            };
            Content = Recipe;

            Application.Current.MainPage = new RecipePage("レシピ");
        }*/
    }
}