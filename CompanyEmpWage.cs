using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationOopsPart2
{
    public class CompanyEmpWage
    {
        public string company;
        public int empRate;
        public int workingDays;
        public int maxHours;
        public int totalWage;

        public CompanyEmpWage(string company, int empRate, int workingDays, int maxHours)
        {
            this.company = company;
            this.empRate = empRate;
            this.workingDays = workingDays;
            this.maxHours = maxHours;
        }

        public void setTotalWage(int totalWage)
        {
            this.totalWage = totalWage;
        }

        public string toString()
        {
            return "Total Employee wage for company " + this.company + " is: " + this.totalWage;
        }
    }
}
