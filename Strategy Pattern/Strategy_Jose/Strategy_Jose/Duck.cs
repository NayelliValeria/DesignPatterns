using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Jose
{
    public class Duck
    {
        public IFlyBehavior flyBehavior { get; set; }
        public IQuackBehavior quackBehavior { get; set; }

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void PerformFly()
        {
            flyBehavior.fly();
        }

        public virtual void Display()
        {
            Console.WriteLine("I look like a duck");
        }
    }
}
