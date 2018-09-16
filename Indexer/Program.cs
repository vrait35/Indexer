using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray myArray = new MyArray();
            myArray[5] = 7;
            Console.WriteLine("myArray[5]="+myArray[5]);
            MyArray myArray2 = new MyArray(7);
            try
            {
                myArray2[9] = 6;
            Console.WriteLine("myArray2[9]=" + myArray2[9]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
