﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Jose
{
    public class MallardDuck:Duck
    {
        public MallardDuck(IFlyBehavior _flyBehavior, IQuackBehavior _quackBehavior)
        {
            flyBehavior = _flyBehavior;
            quackBehavior = _quackBehavior;
        }
           public override void Display()
        {
            Console.WriteLine("I look like a Mallard Duck");
        }
    }
}
