using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();
            list.Add("Hello");
            list.Add("Hello");
            list.Add("Hello");
            list.Add("Hello");
            list.Add("Hello");
            list.Add("Hello");
        }
    }
}
