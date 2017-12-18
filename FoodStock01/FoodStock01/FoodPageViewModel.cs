using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodStock01
{
    class FoodPageViewModel
    {

        public ObservableCollection<Food> Foods
        {
            get;
            private set;
        }


        public FoodPageViewModel()
        {
            if (FoodModel.SelectFood() != null)//
            {
                var query = FoodModel.SelectFood();

                Foods = new ObservableCollection<Food>();
                foreach (var food in query)
                {
                    Food f = new Food
                    {
                        F_name = food.F_name,
                        F_result = food.F_result
                    };
                    Foods.Add(f);
                }

            }
            else
            {
                Foods = new ObservableCollection<Food> {
                    new Food {
                       F_name = "NoData",
                       //F_date = new DateTime(1970,1,1)
                       F_result = 999
                    }
                };
            }
        }

    }


    public class Food
    {
        //public int F_no { get; set; }//余計かも
        public string F_name { get; set; }
        //public DateTime F_date { get; set; }
        public int F_result { get; set; }
    }
}