using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Int32.Parse(Console.ReadLine());
            int i= Int32.Parse(Console.ReadLine());

            Console.WriteLine((n & (1 << i))/ (1 << i));
            
        }
    }
}
