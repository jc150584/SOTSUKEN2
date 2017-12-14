using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodStock01
{
    public partial class EntryNavi : NavigationPage
    {
        public EntryNavi(Page page) : base(page)
        {
            Title = "登録";
            Icon = "plus32.png";
        }
    }
}
