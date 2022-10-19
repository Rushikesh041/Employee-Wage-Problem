namespace Employees
{
     class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_FULL_TIME = 2;
            int IS_PART_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variables
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            //Calculations
            int empCheck = random.Next(0,3);
            if (empCheck == IS_PART_TIME)
            {
                emphrs = 4;
            }
            else if (empCheck == IS_FULL_TIME ) 
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