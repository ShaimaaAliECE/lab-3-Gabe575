using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        public Treasure(String name, int score = 0, int value = 0) : base(name, score, value)
        {
            
        }
        private void UpdateTotalScore()
        {
            Console.WriteLine($"Total Score is updated to: {CollectionBoard.TotalScore}");
        }
        public override void AddMe(List<Collectable> list) {
            UpdateTotalScore();
            base.AddMe(list);
        }
    }
}
