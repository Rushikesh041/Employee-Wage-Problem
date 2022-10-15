namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject Airtel = new EmpWageBuilderObject("Airtel", 30, 30, 140);
            EmpWageBuilderObject Jio = new EmpWageBuilderObject("Jio", 40, 28, 130);
            EmpWageBuilderObject VI = new EmpWageBuilderObject("VI", 25, 30, 120);
            EmpWageBuilderObject BSNL = new EmpWageBuilderObject("BSNL", 30, 25, 100);
            Airtel.computeEmpWage();
            Console.WriteLine(Airtel.toString());
            Jio.computeEmpWage();
            Console.WriteLine(Jio.toString());
            VI.computeEmpWage();
            Console.WriteLine(VI.toString());
            BSNL.computeEmpWage();
            Console.WriteLine(BSNL.toString());

        }
    }
}