﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spring.Model
{
    public class Teacher : Human
    {
        public override void DoSomeThing()
        {
            Console.WriteLine(this.Name + "theaching");
        }
    }
}
