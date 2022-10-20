namespace Employees
{
    class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        static void Main(string[] args)
        {
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
            }
            Console.WriteLine( "Total Emp Wage= " +totalEmpWage );
        }
    }
}