namespace Employees
{
     class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            //Constant
            int IS_FULL_TIME = 1;
            Random ran = new Random();
            //Checking
            int empCheck = ran.Next(0,2);
=======
            //Constants
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            //Calculations
            int empCheck = random.Next(0,2);
>>>>>>> UC2DailyWage
            if (empCheck == IS_FULL_TIME)
            {
                emphrs = 8;

            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("EMP WAGE : "+empwage);
        }
    }
}