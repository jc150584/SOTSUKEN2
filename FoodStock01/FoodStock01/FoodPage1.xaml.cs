using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage1 : ContentPage
    {
        public FoodPage1(string title)
        {
            InitializeComponent();

            var ar = new ObservableCollection<Data>(); 
            ar.Add(new Data { Name = "バナナ", Date = "2"});
            ar.Add(new Data { Name = "りんご", Date = "4" });
            ar.Add(new Data { Name = "トマト", Date = "3" });
            ar.Add(new Data { Name = "いちご", Date = "4" });
            ar.Add(new Data { Name = "にんじん", Date = "6" });

            // テンプレートの作成
            var cell = new DataTemplate(typeof(ImageCell));        // <-3
            cell.SetBinding(ImageCell.TextProperty, "Name");        // <-4
            cell.SetBinding(ImageCell.DetailProperty, "Date");     // <-5

            // リストビューを生成する
            var listView = new ListView
            {
                ItemsSource = ar,
                RowHeight = 50
            };

            Content = new StackLayout
            { 
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0), // iOSのみ上部にマージンをとる
                Children = { listView }
            };
        }

        class Data
        { // <-1
            public String Name { get; set; }
            public String Date { get; set; }
        }
    }
}