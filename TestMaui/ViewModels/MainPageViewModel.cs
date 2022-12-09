using System;
using TestMaui.Models;

namespace TestMaui.ViewModels
{
    public partial class MainPageViewModel
    {
        public List<Item> Items { get; }

        public MainPageViewModel()
        {
            var item1 = new Item("Item1", false);
            var item2 = new Item("Item2", true);

            Items = new List<Item>();

            Items.Add(item1);
            Items.Add(item2);
        }
    }
}

