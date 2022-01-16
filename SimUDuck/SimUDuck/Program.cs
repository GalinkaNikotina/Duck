using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();
            ducks.Add(new MallardDuck());
            ducks.Add(new RedheadDuck());
            ducks.Add(new RubberDuck());
            ducks.Add(new DecoyDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Quack();
                duck.Fly();
            }
            Console.ReadKey();
        }
    }
}
