using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(String name) : base(name)
        {
            Description = name;

        }
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }
        public override void Display()
        {
            Console.Write($"MagicWand {Description} is displayed\n");
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
}
