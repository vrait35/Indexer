using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class MyArray
    {                
        public int[] Array { get; set; }
        public int this[int index]
        {
            get {
                try
                {
                    return Array[index];
                }
                catch
                {
                    throw new Exception("Вы пытаетесь взять значения у переменной которой не существует!");
                }
            }
            set
            {
                try
                {
                    Array[index] = value * value;
                }
                catch {
                    throw new Exception("Вы пытаетесь присвоить значения не существующей переменной!");
                }
            }
        }
        public MyArray()
        {
            Array = new int[1000];
        }
        public MyArray(int size)
        {
            Array = new int[size];
        }
    }
}
