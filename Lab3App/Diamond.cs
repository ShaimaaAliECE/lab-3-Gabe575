using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        private int score;
        public Diamond(String name, int score) : base(name, score)
        {
            Description = name;
            this.score = score;
        }
        public override void Display()
        {
            Console.Write($"Diamond {Description} is displayed\n");
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
        }
    }
}
