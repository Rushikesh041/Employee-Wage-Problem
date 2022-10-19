using System;
using System.Runtime.CompilerServices;
namespace Employees
{
   
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();

            Console.WriteLine("Enter y to Enter Company Details or otherwise enter any key : ");
            var input = Console.ReadLine();
            while (input == "y")
            {
                var obj = UserInput();
                empWageBuilder.addcompanyEmpWage(obj.company, obj.empRatePerHour, obj.numOfWorkingDays, obj.maxHoursPerMonth);
                Console.WriteLine("Enter y to Enter Company Details or otherwise enter any key :");
                input = Console.ReadLine();
            }
            empWageBuilder.computeEmpWage();

            Console.WriteLine("Enter g to get Company Details : ");
            var name = Console.ReadLine();
            while (name == "g")
            {
                var detail = empWageBuilder.companyDetailsByName(Console.ReadLine());
                Console.WriteLine("Comapny Name : " + detail.company);
                Console.WriteLine("Employee Rate Per Hour : " + detail.empRatePerHour);
                Console.WriteLine("Number Of Working Days : " + detail.numOfWorkingDays);
                Console.WriteLine("Maximum Hours Per Month : " + detail.maxHoursPerMonth);

                Console.WriteLine("Enter g to get Company Details : ");
                name = Console.ReadLine();
            }
        }
        public static CompanyEmpWage UserInput()
        {
            Console.WriteLine("Enter Company Name : ");
            string compName = Console.ReadLine();

            Console.WriteLine("Enter Employee Rate Per Hour : ");
            int empRatePerHour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter No of Working Days : ");
            int numOfDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maximum Hours Per Month : ");
            int maxWorkingHourPerMonth = Convert.ToInt32(Console.ReadLine());

            return new CompanyEmpWage(compName, empRatePerHour, numOfDays, maxWorkingHourPerMonth)
            {
                company = compName,
                empRatePerHour = empRatePerHour,
                numOfWorkingDays = numOfDays,
                maxHoursPerMonth = maxWorkingHourPerMonth
            };
        }
    }
}