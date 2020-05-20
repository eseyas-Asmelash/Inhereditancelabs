using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class RandomList : List<string>
    {

        public string RandomString()
        {
            var rand = new Random();
            int random = rand.Next(base.Count);

            string str = base[random];

            base.RemoveAt(random);

            return  $"{str} is removed!";
        }

    }
}
