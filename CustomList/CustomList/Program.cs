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
            CustomList<string> testList = new CustomList<string>();
            testList.Add("Booster");
            testList.Add("Retro");
            testList.Add("FIDO");
            testList.Add("GNC");
            testList.Add("Control");
            testList.Add("CAPCOM");
            string status = "Go";
            int index = 0;
            //Act
            foreach (var element in testList)
            {
                testList.Insert(index, status);
                index++;
            }
            Console.WriteLine(testList);
        }
    }
}
