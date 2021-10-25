using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_details_3
{
	class Program
	{
		String name;
		int empId;
		String address;
		long mobileNo;
		String email;
		String qualification;
		DateTime joiningDate;
		int salary;

		static void Main(String[] args)
		{


			Console.WriteLine("press any number");
			int enter;
			enter = Convert.ToInt32(Console.ReadLine());
			Program p = new Program();
			switch (enter)
			{

				case 1:
					Console.WriteLine("ADD ALL DETAILS");
					Console.WriteLine("Enter your name please");
					p.name = Console.ReadLine();

					Console.WriteLine("Enter emp id please");
					p.empId = Int32.Parse(Console.ReadLine());

					Console.WriteLine("Enter your address please");
					p.address = Console.ReadLine();

					Console.WriteLine("Enter your mobile number please");
					p.mobileNo = long.Parse(Console.ReadLine());

					Console.WriteLine("Enter your email id please");
					p.email = Console.ReadLine();

					Console.WriteLine("Enter your qualifiaction");
					p.qualification = Console.ReadLine();

					Console.WriteLine("Enter your joining date please");
					p.joiningDate = DateTime.Parse(Console.ReadLine());

					Console.WriteLine("Enter your salary please");
					p.salary = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("Name is:{0}\nempId is:{1}\nmobileNumber is:{2}\nemail is{3}\nannual salary is", p.name, p.empId, p.mobileNo, p.email, p.salary * 12);

					break;



				case 2:

					Console.WriteLine("UPDATE YOUR DETAILS");
					Console.WriteLine("update your name please");
					p.name = Console.ReadLine();

					Console.WriteLine("update emp id please");
					p.empId = Int32.Parse(Console.ReadLine());

					Console.WriteLine("update your address please");
					p.address = Console.ReadLine();

					Console.WriteLine("update your mobile number please");
					p.mobileNo = long.Parse(Console.ReadLine());

					Console.WriteLine("update your email id please");
					p.email = Console.ReadLine();

					Console.WriteLine("update your qualifiaction");
					p.qualification = Console.ReadLine();

					Console.WriteLine("update your joining date please");
					p.joiningDate = DateTime.Parse(Console.ReadLine());

					Console.WriteLine("Updare your salary please");
					p.salary = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(p.salary);

					Console.WriteLine("Name is:{0}\nempId is:{1}\nmobileNumber is:{2}\nemail is{3}\nannual salary is", p.name, p.empId, p.mobileNo, p.email, p.salary * 12);
					break;

				case 3:
					Console.WriteLine("Name is:{0}\nempId is:{1}\nmobileNumber is:{2}\nemail is{3}\nannual salary is", p.name, p.empId, p.mobileNo, p.email, p.salary * 12);

					break;
			}



		}
	}
}