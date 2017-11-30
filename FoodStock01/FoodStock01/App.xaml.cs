using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;


namespace FoodStock01
{
    public partial class App : Application
    {
        public App()
        {

            // TabbedPageをMainPageとしてセットする
            MainPage = new TabbedPage()
            {
                Children = {
                   new FoodPage1("食材"),
                   new StockPage("保存"),
                   new EntryPage1("登録"),
                   new MemoPage("メモ"),
                   new SettingPage("設定")
                }
            };
        }
    }
}
