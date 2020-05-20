using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList lst = new RandomList();

            lst.Add("hello");
            lst.Add("Ciao");
            lst.Add("Selam");
            lst.Add("hola");
            lst.Add("Namaste");
            lst.Add("ni hao");
            lst.Add("Salut");
            lst.Add("hej");


            Console.WriteLine(lst.RandomString()); 

        }
    }
}
