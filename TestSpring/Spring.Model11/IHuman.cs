using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Model
{
    interface IHuman
    {
        void DoSomeThing();
    }
    public abstract class Human : IHuman
    {
        public string Name { get; set; }
        public abstract void DoSomeThing();
    }
}
