using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Duck
    {
        public virtual void Quack()
        {
            Console.WriteLine("Quack! Quack! Quack!");
        }

        public void Swim()
        {
            Console.WriteLine("I'm swim");
        }

        public virtual void Fly()
        {
            Console.WriteLine("I'm fly");
        }

        public abstract void Display();
    }
}
