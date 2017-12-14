using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StockPage1 : ContentPage
	{
		public StockPage1 (string title)
		{
            //タブに表示される文字列
            Title = title;

            InitializeComponent ();
		}

        //プラスがクリックされた
        void OnPlus_Clicked(object sender, EventArgs args)
        {
            int num = Convert.ToInt32(((Button)sender).Text) + 1;
            DisplayAlert("UPDATE文書いてね", num.ToString(), "ok");
        }

        //マイナスがクリックされた
        void OnMinus_Clicked(object sender, EventArgs args)
        {
            int num = Convert.ToInt32(((Button)sender).Text) - 1;
            DisplayAlert("UPDATE文書いてね", num.ToString(), "ok");
        }
    }
}