using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationOopsPart2
{
    public class EmpWageBuilderUC11:IEmpWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderUC11()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }


        void IEmpWage.addCompanyEmpWage(string company, int empRate, int workingDays, int maxHours)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empRate, workingDays, maxHours);
            numOfCompany++;
        }


        void IEmpWage.computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                //Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }

        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHours && totalWorkingDays < companyEmpWage.workingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days: " + totalWorkingDays + " Emp Hours: " + empHrs);

            }
            int wage = totalEmpHrs * companyEmpWage.empRate;
            Console.WriteLine("Total Wage: " + wage);
            return totalEmpHrs * companyEmpWage.empRate;
        }
    }
}
