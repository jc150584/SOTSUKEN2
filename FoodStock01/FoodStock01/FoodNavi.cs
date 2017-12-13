using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FoodStock01
{
    public class FoodNavi : NavigationPage
    {
        public FoodNavi()
        {
            Title = "食材リスト";
            new FoodPage1("食材");
        }
    }
}