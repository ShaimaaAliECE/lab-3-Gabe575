using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        public CollectionBoard Board;
        protected String Description;
        public Collectable(String name, int score = 0, int value = 0) {
            Description = name;
        }

        public virtual void AddMe(List<Collectable> list)
        {
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }

        public abstract void Display();
    }
}
