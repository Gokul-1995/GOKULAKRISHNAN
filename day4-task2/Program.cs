using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] companyempDetails;
            int eNo, eAcount;
            Console.WriteLine("ENTER THE NUMBER OF EMPLOYEES WORKING IN YOUR COMPANY");
            eNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE NUMBER OF ACCOUNTS OF EMPLOYEES");
            eAcount = Convert.ToInt32(Console.ReadLine());

            companyempDetails = new int[eNo, eAcount];

            for (int i = 0; i < eNo; i++)
            {
                int temp = 0;
                Console.WriteLine("ENTER CUSTOMER NAME");
                string name = Console.ReadLine();

                for (int j = 0; j < eAcount; j++)
                {


                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("ENTER 1 ACCOUNT BALANCE");
                            break;
                        case 1:
                            Console.WriteLine("ENTER 2 ACCOUNT BALANCE");
                            break;
                        case 2:
                            Console.WriteLine("ENTER 3 ACCOUNT BALANCE");
                            break;

                    }
                   
                     temp = temp + Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine(name + " is having tottal balance is  :" + temp);
            }
        }
    }
}
