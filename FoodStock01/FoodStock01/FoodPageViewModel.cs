using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodStock01
{
    class FoodPageViewModel
    {
        public ObservableCollection<Magic> Magics
        {
            get;
            private set;
        }

        public FoodPageViewModel()
        {
            Magics = new ObservableCollection<Magic> {
                new Magic{
                    Name = "バナナ",
                    Date = "4",
                    Cbox = "\u2610"
                },
                new Magic{
                    Name = "人参",
                    Date = "5",
                     Cbox = "\u2610"
                },
                new Magic{
                    Name = "トマト",
                    Date = "7",
                    Cbox = "\u2610"
                },
                new Magic{
                    Name = "ピーマン",
                    Date = "3",
                    Cbox = "\u2610"
                },
                new Magic{
                    Name = "ほうれん草",
                    Date = "3",
                    Cbox = "\u2610"
                },
            };
        }
    }

    public class Magic
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Cbox { get; set; }
    }

}
