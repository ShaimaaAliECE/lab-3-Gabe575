using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        private int score;
        private int Value;
        public Coin(String name, int score, int value) : base(name, score, value)
        {
            Description = name;
            Value = value;
            this.score = score;

        }
        private void UpdateTotalValue()
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            CollectionBoard.TotalValue += Value;
            CollectionBoard.TotalScore += score;
        }
        public override void Display()
        {
            Console.Write($"Coin {Description} is displayed\n");
        }
        public override void AddMe(List<Collectable> list) {
            UpdateTotalValue();
            base.AddMe(list);
        }
    }
}
