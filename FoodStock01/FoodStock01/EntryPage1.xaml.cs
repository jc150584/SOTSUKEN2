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
    public partial class EntryPage1 : ContentPage
    {
        /***ここからフィールド***/
        DateTime d; //フードピッカーの値を一時的に保持する
        TimeSpan s; //後で使うかも

        DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);//現在日付

        int result;

        FoodPage1 page;

        /***ここまでフィールド***/

        public EntryPage1(string title)
        {
            //タイトル
            Title = title;

            //アイコン
            Icon = "plus32.png";

            //初期化
            InitializeComponent();
        }
        void SelectSwitch(object sender, ToggledEventArgs args)
        {
            //保存食品
            if (args.Value)
            {
                FoodPicker.IsEnabled = false;
                NumEntry.IsEnabled = true;
                UnitEntry.IsEnabled = true;

            }
            //食材
            else
            {
                NumEntry.IsEnabled = false;
                UnitEntry.IsEnabled = false;
                FoodPicker.IsEnabled = true;
            }
        }

        /***************「登録ボタン」が押された時*********************/
        private void Insert01_Clicked(object sender, EventArgs e)
        {
            //Foodテーブルにインサートする
            //FoodModel.InsertFood(1, NameEntry.Text, d);//
            //DisplayAlert(NameEntry.Text, d.ToString(), "ok");

            FoodModel.InsertFood(1, NameEntry.Text, result);//
            DisplayAlert(NameEntry.Text, result.ToString(), "ok");
        }

        /***************「すべて削除ボタン」が押された時********************/
        private void Insert02_Clicked(object sender, EventArgs e)
        {
            FoodModel.DeleteAllFood();
        }

        /*************フードピッカーで日付を選択したとき******************/
        private void FoodPicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            //d = FoodPicker.Date;
            d = new DateTime(FoodPicker.Date.Year, FoodPicker.Date.Month, FoodPicker.Date.Day);

            s = d - now;

            result = s.Days;

        }
    }
}