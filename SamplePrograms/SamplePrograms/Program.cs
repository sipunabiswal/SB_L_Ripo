using System;

namespace SamplePrograms
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int inputInt = Convert.ToInt32( Console.ReadLine());
            Double inputDouble = Convert.ToDouble(Console.ReadLine());
            string inputStr = Console.ReadLine();

            Console.WriteLine(inputInt + inputDouble);
            Console.WriteLine(inputDouble + inputDouble);
            Console.WriteLine("S" + inputStr);

                Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
