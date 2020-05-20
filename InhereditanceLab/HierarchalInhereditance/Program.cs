using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchalInhereditance
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog doggy = new Dog();
            Cat catty = new Cat();

            doggy.Eat();
            doggy.Bark();

            catty.Eat();
            catty.Meow();
        }
    }
}
