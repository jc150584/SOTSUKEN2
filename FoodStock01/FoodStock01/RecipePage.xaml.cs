﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipePage : ContentPage
    {
        public RecipePage(string title)
        {
            //タイトル
            Title = title;

            //アイコン
            Icon = "coffee32.png";

            InitializeComponent();

            /* Label label1 = new Label();
             label1.Text = "レシピ";
             label1.Margin = new Thickness(20,30,20,10);*/

            recipeView.Source = "http://cookpad.com/";

            /*Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            Content = new {label1, webView};*/
        }
    }
}