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
    public partial class CustomButton : ContentView
    {
        public static readonly BindableProperty NameTextProperty =
           BindableProperty.Create(
               "NameText",
               typeof(string),
               typeof(CustomButton),
               null,
               propertyChanged: (bindable, oldValue, newValue) =>
               {
                   ((CustomButton)bindable).textNameLabel.Text = (string)newValue;
               });

        public static readonly BindableProperty CountTextProperty =
          BindableProperty.Create(
              "CountText",
              typeof(string),
              typeof(CustomButton),
              null,
              propertyChanged: (bindable, oldValue, newValue) =>
              {
                  ((CustomButton)bindable).textCountLabel.Text = (string)newValue;
              });

        public static readonly BindableProperty IsCheckedProperty =
           BindableProperty.Create(
               "IsChecked",
               typeof(string),
               typeof(CustomButton),
               null,
               propertyChanged: (bindable, oldValue, newValue) =>
               {
                   CustomButton button = (CustomButton)bindable;
                   ((CustomButton)bindable).buttomImage.Text = (string)newValue;

                   //イベント発行
                   EventHandler<bool> eventHandler = button.CheckedChanged;
                   if (eventHandler != null)
                   {
                       eventHandler(button, (bool)newValue);
                   }
               });

        public event EventHandler<bool> CheckedChanged;

        public CustomButton()
        {
            InitializeComponent();
        }

        public string NameText
        {
            set { SetValue(NameTextProperty, value); }
            get { return (string)GetValue(NameTextProperty); }
        }

        public string CountText
        {
            set { SetValue(CountTextProperty, value); }
            get { return (string)GetValue(CountTextProperty); }
        }

        public string IsChecked
        {
            set { SetValue(IsCheckedProperty, value); }
            get { return (string)GetValue(IsCheckedProperty); }
        }
    }
}