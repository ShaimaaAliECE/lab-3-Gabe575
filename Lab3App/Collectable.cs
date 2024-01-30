using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Collectable : Displayable
    {
        public CollectionBoard Board;
        protected String Description;
        public Collectable(String name, int score = 0, int value = 0) {
            
        }
        
        public virtual void AddMe(List<Collectable> list)
        {
            
        }

        public abstract void Display();
    }
}
