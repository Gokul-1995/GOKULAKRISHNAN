using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY6_TASK1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your Name,Age,Address,Contact Number,Qalification ,Experience :");
            String Details = Console.ReadLine();

            String[] detail = Details.Split(',');
            foreach (String all in detail)

            {
                Console.WriteLine(all);
            }

            Console.ReadKey();
        }
    }
}
