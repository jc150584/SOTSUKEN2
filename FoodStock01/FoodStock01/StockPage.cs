using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FoodStock01
{
    public class StockPage : ContentPage
    {
        public StockPage(string title)
        {
            //タブに表示される文字列
            Title = title;

            //ラベルを生成
            var label1 = new Label
            {
                FontSize = 40,
                //ビューの中央に配置
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                Text = title
            };

            Content = label1;
        }
    }
}