using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
    public partial class FoodPage : ContentPage
    {
        public FoodPage(string title)
        {
            //タイトル
            Title = title;

            var cell = new DataTemplate(typeof(ImageCell));

            cell.SetBinding(TextCell.TextProperty, "Name");
            cell.SetBinding(TextCell.DetailProperty, "Days"+"日");
            cell.SetBinding(ImageCell.ImageSourceProperty, "Image");

            list.ItemTemplate = cell;

        }
    }


    public class Food
    {
        public string Name { get; set; }
        public string Days { get; set; }
        //URL for our image!
        public string Image { get; set; }
    }


    public class MonkeysViewModel
    {
        public System.Collections.ObjectModel.ObservableCollection<Food> Foods { get; set; }

        public MonkeysViewModel()
        {
            Foods = new System.Collections.ObjectModel.ObservableCollection<Food>();
            Foods.Add(new Food
            {
                Name = "ばなな",
                Days = "3",
                //new monkey image!
                Image = "fruit_banana.png",
            });
        }
    }

}