using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Jose.QuackBehaviors
{
    class FlyWithWings:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("Look how I fly");
        }
    }
}
