using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Jose.QuackBehaviors
{
    class FlyNoWay:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I Cannot fly");
        }
    }
}
