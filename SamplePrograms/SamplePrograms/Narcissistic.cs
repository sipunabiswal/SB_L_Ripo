/*using System;

namespace SamplePrograms
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            int input, sum = 0,digitCount=0,num;
            int.TryParse(Console.ReadLine(), out input);

            for (int i = input; i > 0; i = i / 10)
            {
                digitCount++;
            }
            num = input;
            while (num > 0)
            {
                sum += (int)Math.Pow(num % 10, digitCount);
                num /= 10;
            }

            bool isNarcissistic;
            if (sum == input)
            {
                isNarcissistic = true;
            }
            else
                isNarcissistic = false;

            Console.WriteLine(isNarcissistic);
        }
    }
}
*/