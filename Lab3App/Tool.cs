using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Tool : Collectable
    {
        public Tool(String name) : base(name)
        {

        }
        public abstract void DoAction();

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }
    }
}
