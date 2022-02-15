using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayOperations.GetDigits(555));
            ArrayOperations.Process(new int[] { 1, 50, 7, 3, -6, -777, 8, 9, 10, -3, 555, -20000, 8, 21, -21, 15, 5555, 10000 });
            Console.Read();
        }
    }
}
