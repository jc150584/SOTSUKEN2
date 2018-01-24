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
    public partial class NextPage : ContentPage
    {
        public NextPage(string url)
        {
            InitializeComponent();

            Title = "レシピ検索";

            var Recipe = new WebView
            {
                Source = new Uri(url),
                HorizontalOptions = LayoutOptions.FillAndExpand,      
            };
            Content = Recipe;

        }
    }
}