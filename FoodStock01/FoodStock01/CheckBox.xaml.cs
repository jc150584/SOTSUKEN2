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
	public partial class CheckBox : ContentView
	{
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create(
                "Text",
                typeof(string),
                typeof(CheckBox),
                null,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    ((CheckBox)bindable).textLabel.Text = (string)newValue;
                });


        public static readonly BindableProperty IsCheckedProperty =
            BindableProperty.Create(
                "IsChecked",
                typeof(bool),
                typeof(CheckBox),
                false,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    //グラフィックを設定
                    CheckBox checkbox = (CheckBox)bindable;
                    checkbox.boxLabel.Text = (bool)newValue ? "\u2611" : "\u2610";

                    //イベント発行
                    EventHandler<bool> eventHandler = checkbox.CheckedChanged;
                    if (eventHandler != null)
                    {
                        eventHandler(checkbox, (bool)newValue);
                    }
                });

        public event EventHandler<bool> CheckedChanged;

        public CheckBox()
        {
            InitializeComponent();
        }

        public string Text
        {
            set { SetValue(TextProperty, value); }
            get { return (string)GetValue(TextProperty); }
        }

        public bool IsChecked
        {
            set { SetValue(IsCheckedProperty, value); }
            get { return (bool)GetValue(IsCheckedProperty); }
        }

        //TapGestureRecognizerハンドラー
        void OnCheckBoxTapped(object sender, EventArgs args)
        {
            IsChecked = !IsChecked;
        }

    }
}