namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addcompanyEmpWage("Airtel", 30, 30, 140);
            empWageBuilder.addcompanyEmpWage("Jio", 40, 28,130);
            empWageBuilder.addcompanyEmpWage("VI", 25, 30, 120);
            empWageBuilder.addcompanyEmpWage("BSNL", 30, 25, 100);
            empWageBuilder.computeEmpWage();

        }
    }
}