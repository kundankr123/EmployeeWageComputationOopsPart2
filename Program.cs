using EmployeeWageComputationOopsPart2;

namespace EmployeeWageComputationOoopsPart2
{
    class Program
    {
        public static void Main(string[] args)
        {

            EmpWageBuilderUC10 capGemini = new EmpWageBuilderUC10("CapGemini", 15, 5, 17);
            EmpWageBuilderUC10 Wipro = new EmpWageBuilderUC10("Wipro", 16, 3, 21);

            Wipro.computeEmpWage();
            Console.WriteLine(Wipro.toString());
            capGemini.computeEmpWage();
            Console.WriteLine(capGemini.toString());
        }
    }
}