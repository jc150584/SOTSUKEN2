using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

using FoodStock01.Helpers;
using FoodStock01.Models;
using FoodStock01.ViewModels;

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
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var monkey = ((ListView)sender).SelectedItem as Monkey;
            if (monkey == null)
                return;


        }
    }
    }
}