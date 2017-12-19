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
        public StockPage1(string title)
        {
            //タブに表示される文字列
            Title = title;

            InitializeComponent();
        }

        //更新ボタンが押された時
        private void Update_Button_Clicked(object sender, EventArgs e)
        {
            Title = "保存";

            InitializeComponent();

        }

        //プラスがクリックされた
        void OnPlus_Clicked(object sender, EventArgs args)
        {
            int num = Convert.ToInt32(((CustomButton)sender).CountText) + 1;
            string no = ((CustomButton)sender).NameText;

            int s_no = int.Parse(no);
            DisplayAlert("1足しました", "主キー" +s_no+ "　個数" + num.ToString(), "ok");
            //
            /***ここから試し***/
            StockFoodModel.UpdateStockPlus(s_no);

            Title = "保存";

            InitializeComponent();
            /***ここまで試し***/
        }

        //マイナスがクリックされた
        void OnMinus_Clicked(object sender, EventArgs args)
        {
            int num = Convert.ToInt32(((CustomButtonMinus)sender).CountText) - 1;
            string name = ((CustomButtonMinus)sender).NameText;
            DisplayAlert("1引きました", name + "　" + num.ToString(), "ok");
        }
    }
}