namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
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
            {
                case 1 :
                   emphrs = 4;
                    break;

                case 2 :
                    emphrs = 8;
                    break;
                 default : 
                    emphrs = 0;
                    break;
>>>>>>> UC4CaseStatement
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EMP WAGE : " + empwage);
        }
    }
}