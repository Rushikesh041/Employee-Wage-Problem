namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addcompanyEmpWage("Airtel", 50, 28, 110);
            empWageBuilder.addcompanyEmpWage("Jio", 60, 26, 100);
            empWageBuilder.addcompanyEmpWage("VI", 40, 30, 120);
            empWageBuilder.addcompanyEmpWage("BSNL", 45, 25, 90);
            empWageBuilder.computeEmpWage();

        }
    }
}