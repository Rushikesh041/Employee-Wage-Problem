using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
        public class EmpWageBuilderArray
        {
        public const int IS_FULL_TIME = 1, IS_PART_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;
        private List<CompanyEmpWage> companyEmpWageArrayList;


        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
            companyEmpWageArrayList = new List<CompanyEmpWage>();
        }
        public void addcompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageArrayList.Add(new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth));
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArrayList[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArrayList[i]));
                Console.WriteLine(this.companyEmpWageArrayList[i].toString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days : " + totalWorkingDays + "Emp Hrs : " + empHrs);
                int dailyWage = empHrs * companyEmpWage.empRatePerHour;
                Console.WriteLine("Daily Wage Of Employee Is : " + dailyWage);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}


