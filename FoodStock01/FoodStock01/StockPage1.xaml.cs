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
            int num = Convert.ToInt32(((CustomButton)sender).CountText) + 1;
            string name = ((CustomButton)sender).NameText;
            DisplayAlert("1足しました", name+"　"+num.ToString(), "ok");
        }

        //マイナスがクリックされた
        void OnMinus_Clicked(object sender, EventArgs args)
        {
            int num = Convert.ToInt32(((CustomButtonMinus)sender).CountText) - 1;
            string name = ((CustomButtonMinus)sender).NameText;
            DisplayAlert("1引きました", name+"　"+num.ToString(), "ok");
        }
    }
}