using Strategy_Jose.Ducks;
using Strategy_Jose.FlyBehaviors;
using Strategy_Jose.QuackBehaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Jose
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //A DEPENDENCY INJECTOR OR FACTORY SHOULD REPLACE ALL THIS DECLARATIONS
            IFlyBehavior canFly = new FlyWithWings();
            IFlyBehavior cantFly = new FlyNoWay();

            IQuackBehavior quack = new Quack();
            IQuackBehavior squeack = new Squeack();
            IQuackBehavior mute = new MuteQuack();

            List<Duck> ducks = new List<Duck>();

            Duck mallardDuck = new MallardDuck(canFly,quack);
            Duck redHeadDuck = new RedHeadDuck(canFly, quack);
            Duck decoyDuck = new DecoyDuck(cantFly, mute);
            Duck rubberDuck = new RubberDuck(cantFly, squeack);

            ducks.Add(mallardDuck);
            ducks.Add(redHeadDuck);
            ducks.Add(decoyDuck);
            ducks.Add(rubberDuck);

            //NOW WE WILL MAKE OUR DUCKS DISPLAY FLY AND QUACK
            foreach (Duck duck in ducks)
            {
                duck.Display();
                duck.PerformFly();
                duck.PerformQuack();

                Console.WriteLine("---------------");
            }

            Console.ReadLine();


        }
    }
}
