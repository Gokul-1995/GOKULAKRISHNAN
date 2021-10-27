using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] numbers;
            Console.WriteLine("ENTER THE SIZE OF THE ARRAY PLEASE!");
            n = Convert.ToInt32(Console.ReadLine());
            numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            double highestSalary = numbers.Max();

            double lowestSalary = numbers.Min();

            double averageSalary = numbers.Sum() / numbers.Length;
            Console.WriteLine("highestSalary is:{0}\nlowestSalary is:{1}\naverageSalary is:{2}", highestSalary, lowestSalary, averageSalary);

         
        }
    }
}
