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
    public partial class CustomButtonMinus : ContentView
    {
        public static readonly BindableProperty NoTextProperty =
           BindableProperty.Create(
               "NoText",
               typeof(string),
               typeof(CustomButtonMinus),
               null,
               propertyChanged: (bindable, oldValue, newValue) =>
               {
                   ((CustomButtonMinus)bindable).textNoLabel.Text = (string)newValue;
               });

        public static readonly BindableProperty NameTextProperty =
           BindableProperty.Create(
               "NameText",
               typeof(string),
               typeof(CustomButtonMinus),
               null,
               propertyChanged: (bindable, oldValue, newValue) =>
               {
                   ((CustomButtonMinus)bindable).textNameLabel.Text = (string)newValue;
               });

        public static readonly BindableProperty CountTextProperty =
          BindableProperty.Create(
              "CountText",
              typeof(string),
              typeof(CustomButtonMinus),
              null,
              propertyChanged: (bindable, oldValue, newValue) =>
              {
                  ((CustomButtonMinus)bindable).textCountLabel.Text = (string)newValue;
              });

        public static readonly BindableProperty UnitTextProperty =
          BindableProperty.Create(
              "UnitText",
              typeof(string),
              typeof(CustomButtonMinus),
              null,
              propertyChanged: (bindable, oldValue, newValue) =>
              {
                  ((CustomButtonMinus)bindable).textUnitLabel.Text = (string)newValue;
              });

        public static readonly BindableProperty IsCheckedProperty =
           BindableProperty.Create(
               "IsChecked",
               typeof(bool),
               typeof(CustomButtonMinus),
               false,
               propertyChanged: (bindable, oldValue, newValue) =>
               {
                   CustomButtonMinus button = (CustomButtonMinus)bindable;

                   //イベント発行
                   EventHandler<bool> eventHandler = button.CheckedChanged;
                   if (eventHandler != null)
                   {
                       eventHandler(button, (bool)newValue);
                   }
               });

        public event EventHandler<bool> CheckedChanged;

        public CustomButtonMinus()
        {
            InitializeComponent();
        }

        public string NoText
        {
            set { SetValue(NoTextProperty, value); }
            get { return (string)GetValue(NoTextProperty); }
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

        public string UnitText
        {
            set { SetValue(UnitTextProperty, value); }
            get { return (string)GetValue(UnitTextProperty); }
        }

        public bool IsChecked
        {
            set { SetValue(IsCheckedProperty, value); }
            get { return (bool)GetValue(IsCheckedProperty); }
        }

        //TapGestureRecognizerハンドラー
        void OnButtonTapped(object sender, EventArgs args)
        {
            IsChecked = !IsChecked;
        }
    }
}