using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        private int score;
        public Treasure(String name, int score = 0, int value = 0) : base(name, score, value)
        {
            this.score = score;
        }
        private void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += score;
            Console.WriteLine($"Total Score is updated to: {CollectionBoard.TotalScore}");
        }
        public override void AddMe(List<Collectable> list) {
            base.AddMe(list);
            UpdateTotalScore();
        }
    }
}
