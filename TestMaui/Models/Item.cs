using System;
using System.Runtime.CompilerServices;

namespace TestMaui.Models
{
    public class Item
    {
        private string name;

        private bool isComplete;

        public string Name
        {
            get => name;
            set
            {
                OnPropChange(name, value);
            }
        }

        public bool IsComplete
        {
            get => isComplete;
            set
            {
                OnPropChange(IsComplete, value);
            }
        }

        public Item(string name, bool isComplete)
        {
            this.name = name;
            this.isComplete = isComplete;
        }

        private void OnPropChange(object oldVal, object newVal, [CallerMemberName] string propName = "")
        {
            Console.WriteLine($"PropChanged: {propName}: {oldVal} -> {newVal}");
        }
    }
}

