namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Company Name : ");
            string CompName = Console.ReadLine();

            Console.WriteLine("Enter Employee Rate Per Hour : ");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter No of Working Days : ");
            int numOfDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Maximum Hours Per Month : ");
            int maxHourMonth = Convert.ToInt32(Console.ReadLine());

            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addcompanyEmpWage(CompName, rate, numOfDays, maxHourMonth);
            empWageBuilder.computeEmpWage();

        }
    }
}