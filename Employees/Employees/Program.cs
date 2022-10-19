namespace Employees
{
     class Program
    {
        static void Main(string[] args)
        {
            //Constant
            int IS_FULL_TIME = 1;
            Random ran = new Random();
            //Checking
            int empCheck = ran.Next(0,2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}