using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FoodStock01;
using System.Windows.Input;

namespace FoodStock01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FoodPage1 : ContentPage
    {
        String s = "http://cookpad.com/search/";

        ContentView qsl; // iOS/Android 用
        ContentView bl; // 黒背景
        bool qslVisible = true;

        public FoodPage1(string title)
        {
            //タイトル
            Title = title;

            InitializeComponent();

            ToolbarItems.Add(new ToolbarItem
            {
                Text = "検索",
                Icon = "search24.png",
                Command = new Command(() =>
                    //ページ遷移
                    Navigation.PushAsync(new NextPage(s))
                ),
            });

            AbsoluteLayout abs = new AbsoluteLayout { };

            // 上に表示される View です。
            // 黒背景を最初に置いて、
            bl = new ContentView
            {
                BackgroundColor = Color.Black,
                Opacity = 0.65d,
            };

            // 更に上に View を被せました。
            qsl = new ContentView
            {
                Content = new StackLayout
                {
                    Children = {
                        // 画像で誤魔化します
                        new Image {
                            Source = "QuickStart.png",
                            WidthRequest = 250,
                            HorizontalOptions = LayoutOptions.End,
                        },
                        new Image {
                            Source = "QuickStartSwipe.png",
                            WidthRequest = 340,
                        },
                        // 閉じると Application Properties に bool 値を保存します。
                        new Button {
                            Text = "閉じる",
                            VerticalOptions = LayoutOptions.EndAndExpand,
                            Command = new Command (()=>{
                                qsl.IsVisible = false;
                                bl.IsVisible = false;
                                qslVisible = false;
                                Application.Current.Properties["qsl"] = qslVisible;
                            }),
                        },
                    }
                }
            };

            // AbsoluteLayout にコントロールを追加しますがその際に
            // Properties Dictionary をチェックして QuickStart Layer を追加しています。
            abs.Children.Add(ml);
            if (Application.Current.Properties.ContainsKey("qsl"))
            {
                var bqsl = (bool)Application.Current.Properties["qsl"];
                if (bqsl)
                    abs.Children.Add(qsl);
            }
            else
            {
                abs.Children.Add(qsl);
            }

            Title = "QuickStartLayer";
            Content = abs;

            SizeChanged += OnPageSizeChanged;
        }
        /// <summary>
        /// 画面サイズ変更時(起動して画面が表示される時)に呼び出されます。この後でないと画面サイズが取得できません。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnPageSizeChanged(object sender, EventArgs args)
        {
            var w = this.Width;
            var h = this.Height;

            AbsoluteLayout.SetLayoutFlags(ml, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(ml, new Rectangle(0d, 0d, w, h));

            AbsoluteLayout.SetLayoutFlags(qsl, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(qsl, new Rectangle(0d, 0d, w, h));
        }

        void ChackBoxChanged(object sender, bool isChecked)
        {
            //選択された時の処理
            if (isChecked)
            {
                s += ((CheckBox)sender).Text + "　";
            }
            //選択が外された時の処理
            else
            {
                s = s.Replace(((CheckBox)sender).Text + "　", "");
            }
        }

        //デリート押された
        //void OnDelete_Clicked(object sender, EventArgs args)
        async void OnDelete_Clicked(object sender, EventArgs args)
        {
            string no = ((CustomButtonDelete)sender).NoText;
            string name = ((CustomButtonDelete)sender).NameText;

            var result = await DisplayAlert("削除", "この食材を削除しますか", "OK", "キャンセル");
            if (result == true)
            {
                int f_no = int.Parse(no);
                FoodModel.DeleteFood(f_no);

                Title = "食材リスト";
                s = "http://cookpad.com/search/";

                InitializeComponent();
            }
        }

        void OnSearch_Clicked(object sender, EventArgs args)
        {
            //ページ遷移
            Navigation.PushAsync(new NextPage(s));
        }

        //引っ張ったとき（更新）
        private async void OnRefreshing(object sender, EventArgs e)
        {
            // 1秒処理を待つ
            await Task.Delay(1000);

            //リフレッシュを止める
            list.IsRefreshing = false;

            Title = "食材リスト";
            s = "http://cookpad.com/search/";

            InitializeComponent();
        }
    }
}