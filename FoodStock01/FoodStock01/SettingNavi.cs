using Xamarin.Forms;

namespace FoodStock01
{
    public partial class SettingNavi : NavigationPage
    {
        public SettingNavi(Page page) : base(page)
        {
            Title = "設定";
            Icon = "gear32.png";
        }
    }
}