using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace FoodStock01
{
    class StockPageViewModel
    {
        public ObservableCollection<Stock> Stocks
        {
            get;
            private set;
        }

        public StockPageViewModel()
        {
            Stocks = new ObservableCollection<Stock> {
                new Stock{
                    Name = "醤油",
                    Count = 2,
                    Unit = "本"
                },
                new Stock{
                    Name = "小麦粉",
                    Count = 1,
                    Unit = "袋"
                },
            };
        }
    }

    public class Stock
    {
        public string Name{ get; set; }
        public int Count { get; set; }
        public string Unit { get; set; }
    }
}
