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
        public ObservableCollection<Magic> Magics
        {
            get;
            private set;
        }

        public FoodPage1(string title)
        {

            //タイトル
            Title = title;

           //アイコン
            Icon = "apple32.png";

            InitializeComponent();

            /*var ar = new ObservableCollection<String>();
            ar.Add(string.Format("ばなな"+"\t"+"4"+"日"+"\u2610"));
            ar.Add(string.Format("にんじん" + "\t" + "5" + "日" + "\u2610"));
            ar.Add(string.Format("とまと" + "\t" + "3" + "日" + "\u2610"));
            ar.Add(string.Format("ぴーまん" + "\t" + "7" + "日" + "\u2610"));


            // リストビューを生成する
            var listView = new ListView
            {
                ItemsSource = ar,
                RowHeight = 50
            };

            var label1 = new Label
            {
                Text = "食品リスト",
                TextColor = Color.DodgerBlue,
                BackgroundColor = Color.Transparent
            };


            Content = new StackLayout
            { 
                Padding = new Thickness(20, 30, 20, 0), 
                Children = { label1, listView }
            };*/



            Magics = new ObservableCollection<Magic> {
                new Magic{
                    Name = "光の白刃",
                    Spell = "我は放つ、光の白刃"
                },
                new Magic{
                    Name = "インディグネイション",
                    Spell = "天光満る処に我は在り、黄泉の門開く処に汝在り、出でよ神の雷"
                },
                new Magic{
                    Name = "ドラグスレイブ",
                    Spell = "黄昏よりも暗き存在（もの）､血の流れよりも赤き存在（もの）時間（とき）の流れに埋もれし偉大なる汝の名において､我ここに闇に誓わん､我らが前に立ち塞がりし全ての愚かなるものに、我と汝が力もて､等しく滅びを与えんことを"
                },
                new Magic{
                    Name = "セラフィックローサイト",
                    Spell = "其は忌むべき芳名にして偽印の使徒、神苑の淵に還れ招かれざる者よ"
                },
                new Magic{
                    Name = "Unlimited Blade Works",
                    Spell = "I am the bone of my sword. Steel is my body, and fire is my blood. I have created over a thousand blades. Unknown to Death. Nor known to Life. Have withstood pain to create many weapons. Yet, those hands will never hold anything. So as I pray, unlimited blade works."
                },
            };

        }

    public class Magic
    {
        public string Name { get; set; }
        public string Spell { get; set; }
    }
}