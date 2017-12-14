using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodStock01
{
    public partial class StockNavi : NavigationPage
    {
        public StockNavi(Page page) : base(page)
        {
            Title = "保存";
            Icon = "cube32.png";
        }
    }
}
