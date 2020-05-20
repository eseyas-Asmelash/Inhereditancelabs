using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            StackofStrings stackStrings = new StackofStrings();
            stackStrings.Push("Hello");
            stackStrings.Push("Hi");
            stackStrings.Push("Ciao");

            Console.WriteLine(stackStrings.Peek());
            Console.WriteLine();
            Console.WriteLine(stackStrings.IsEmpty());
            Console.WriteLine();
            Console.WriteLine(stackStrings.Pop());
            Console.ReadKey();
        }
    }
}
