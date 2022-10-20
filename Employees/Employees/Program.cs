using System;
using System.Runtime.CompilerServices;
namespace Employees
{
   
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            //Constant
            int IS_FULL_TIME = 1;
            Random ran = new Random();
            //Checking
            int empCheck = ran.Next(0,2);
=======
            //Constants
            int IS_FULL_TIME = 1;
=======
            //Constants
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
>>>>>>> UC3PartTime
=======
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
>>>>>>> UC4CaseStatement
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
<<<<<<< HEAD
            //Calculations
<<<<<<< HEAD
            int empCheck = random.Next(0,2);
>>>>>>> UC2DailyWage
            if (empCheck == IS_FULL_TIME)
=======
            int empCheck = random.Next(0,3);
            if (empCheck == IS_PART_TIME)
            {
                emphrs = 4;
            }
            else if (empCheck == IS_FULL_TIME ) 
>>>>>>> UC3PartTime
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
=======
            int empCheck = random.Next(0, 3);
            switch (empCheck)
=======
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
>>>>>>> UC5WorkDays20
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;

<<<<<<< HEAD
                case 2 :
                    emphrs = 8;
                    break;
                 default : 
                    emphrs = 0;
                    break;
>>>>>>> UC4CaseStatement
=======
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("EMP WAGE : " + empWage);
                
>>>>>>> UC5WorkDays20
=======
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();

            Console.WriteLine("Enter y to Enter Company Details or otherwise enter any key : ");
            var input = Console.ReadLine();
            while (input == "y")
            {
                var obj = UserInput();
                empWageBuilder.addcompanyEmpWage(obj.company, obj.empRatePerHour, obj.numOfWorkingDays, obj.maxHoursPerMonth);
                Console.WriteLine("Enter y to Enter Company Details or otherwise enter any key :");
                input = Console.ReadLine();
>>>>>>> UC14FinalSolution
            }
            empWageBuilder.computeEmpWage();

            Console.WriteLine("Enter g to get Company Details : ");
            var name = Console.ReadLine();
            while (name == "g")
            {
                Console.WriteLine("Enter Company Name  ");
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