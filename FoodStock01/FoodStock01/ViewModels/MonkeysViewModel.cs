using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodStock01.Helpers;
using FoodStock01.Models;
using System.Collections.ObjectModel;

namespace FoodStock01.ViewModels
{
    public class MonkeysViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }
        public ObservableCollection<Grouping<string, Monkey>> MonkeysGrouped { get; set; }

        public MonkeysViewModel()
        {

            Monkeys = MonkeyHelper.Monkeys;
            MonkeysGrouped = MonkeyHelper.MonkeysGrouped;
        }

        public int MonkeyCount => Monkeys.Count;
    }
}
