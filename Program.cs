using EmployeeWageComputationOopsPart2;

namespace EmployeeWageComputationOoopsPart2
{
    class Program
    {
        public static void Main(string[] args)
        {

            EmpWageBuilderUC9 capGemini = new EmpWageBuilderUC9("CapGemini", 15, 5, 17);
            EmpWageBuilderUC9 Wipro = new EmpWageBuilderUC9("Wipro", 16, 3, 21);

            Wipro.computeEmpWage();
            Console.WriteLine(Wipro.toString());
            capGemini.computeEmpWage();
            Console.WriteLine(capGemini.toString());
        }
    }
}