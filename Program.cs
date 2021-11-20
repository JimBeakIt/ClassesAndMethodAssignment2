using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethodAssignment2
{
    public class Program
    {
        public static int Data1 { get; set; }
        public static int Data2 { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string uNum1 = Console.ReadLine();
            Data1 = Int32.Parse(uNum1);

            Console.WriteLine("Optional: Enter another number:");
            string uNum2 = Console.ReadLine();
            Data2 = Int32.Parse(uNum2);


            int result = Data1 + 6;
            Console.WriteLine("The result is " + result);
            Console.ReadLine();
        }
    }
}

