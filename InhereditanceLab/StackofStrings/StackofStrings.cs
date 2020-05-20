using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackofStrings 
{
    class StackofStrings : Stack<string>
    {
        private List<string> data = new List<string>();
        public void Push(string item)
        {
            data.Add(item);
        }    
        public string Pop()
        {
            string str = data[data.Count -1];
            data.RemoveAt(data.Count - 1);
            return str;
        }
        public string Peek()
        {
            return data[0];
        }
        public bool IsEmpty()
        {
            return (data.Count <= 0);
        }

    }
}
