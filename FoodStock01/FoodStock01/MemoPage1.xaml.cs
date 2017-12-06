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
    public partial class MemoPage1 : ContentPage
    {
        public MemoPage1(string title)
        {
            //タブに表示される文字列
            Title = title;

            //アイコン
            Icon = "note32.png";

            //画面初期化
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            ScrollView1.ScrollToAsync(Label07, ScrollToPosition.Center, true);
        }
    }
}