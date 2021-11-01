using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Email = "gokul95@gmail.com";
            user1.Password = "********";
            user1.Mobile_no = 9876543210;
            user1.Address = "Mannargudi-614001";
            Console.WriteLine("Details of user");
            Console.WriteLine(user1.ToString());

            Product p1 = new Product();
            p1.Id = 101;
            p1.Name = "ONE PLUS";
            p1.Category = "MOBILES";
            p1.Price = 35000.00;
            Console.WriteLine("Details of product");
            Console.WriteLine(p1.ToString());


            Console.WriteLine("***************************************************************");
            Console.WriteLine("Details are Stored in Array");
            User[] u1 = new User[4];
            u1[0].Email = "gokul95@gmail.com";
            u1[1].Password = "********";
            u1[2].Mobile_no = 9876543210;
            u1[3].Address = "Mannargudi-614001";
            
            for (int i = 0; i < u1.Length; i++)
            {
                Console.WriteLine(u1[i]);

            }
            foreach (var item in u1)
            {
                Console.WriteLine(item);
            }


            Product[] p = new Product[4];
            p[0].Id = 101;
            p[1].Name = "BACK CASE";
            p[2].Category = "MOBILE ACCESSORIES";
            p[3].Price = 500;
           
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine(p[i]);

            }
            foreach (var item in p)
            {
                Console.WriteLine(item);
            }

        }
    }
}

