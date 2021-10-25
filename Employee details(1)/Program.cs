using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_details_1_
{
    class Program
    {
       public static void Main(string[] args)
        {


			string name;
			string emailId;
			int empId;
			long mobileNumber;
			DateTime dob;
			DateTime dateofjoining;
			int salary;


			Console.WriteLine("Enter Your Name");
			name = Console.ReadLine();
			Console.WriteLine("Enter Your emailId");
			emailId = Console.ReadLine();
			Console.WriteLine("Enter Your empId");
			empId = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Your mobileNumber");
			mobileNumber = Convert.ToInt64(Console.ReadLine());
			Console.WriteLine("Enter Your dob");
			dob = Convert.ToDateTime(Console.ReadLine());
			Console.WriteLine("Enter Your dateofjoining");
			dateofjoining = Convert.ToDateTime(Console.ReadLine());
			Console.WriteLine("Enter Your salary");
			salary = Convert.ToInt32(Console.ReadLine());

			DateTime today = DateTime.Now;
			int EXPERIENCE = today.Year-dateofjoining.Year


			Console.WriteLine("Employee Details Are:");
			Console.WriteLine("NAME:" + name);
			Console.WriteLine("EXPERIENCE:");

			Console.WriteLine("ANNUAL SALARY:" + salary * 12);
		}
    }
}
