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
            var result = new IntPar();

            Console.WriteLine("Enter a number:");
            string uNum1 = Console.ReadLine();
            Data1 = Convert.ToInt32(uNum1);

            Console.WriteLine("Optional: Enter another number:");
            string uNum2 = Console.ReadLine();
            if (!string.IsNullOrEmpty(uNum2))
            Data2 = Int32.Parse(uNum2);


            var result2 = result.NumU(Num1: Data1, Num2: Data2);
            Console.WriteLine("The result is " + result2);
            Console.ReadLine();
        }
    }
}

