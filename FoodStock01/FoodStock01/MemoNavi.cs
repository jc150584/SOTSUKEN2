using Xamarin.Forms;

namespace FoodStock01
{
    public partial class MemoNavi : NavigationPage
    {
        public MemoNavi(Page page) : base(page)
        {
            Title = "メモ";
            Icon = "note32.png";
        }
    }
}