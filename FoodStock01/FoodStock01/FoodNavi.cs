using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FoodStock01
{
    public partial class FoodNavi : NavigationPage
    {
        public FoodNavi(Page page) : base(page)
        {
            Title = "食材";
            Icon = "apple32.png";
        }
    }
}