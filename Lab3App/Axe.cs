using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(String name) : base(name)
        {
            Description = name;

        }
        private void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
        public override void Display()
        {
            Console.Write($"Axe {Description} is displayed\n");
        }
        public override void AddMe(List<Collectable> list)
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction();
            base.AddMe(list);
        }
    }
}
