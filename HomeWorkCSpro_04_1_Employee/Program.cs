using System.Text;

namespace HomeWorkCSpro_04_1_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Employee emp1 = new Employee("Петро", "Інженер", 20000);
            Employee emp2 = new Employee("Олена", "Бухгалтер", 35000);

            emp1 = emp1 + 5000;
            emp2 = emp2 - 2000;

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 > emp2);
            Console.WriteLine(emp1 < emp2);
        }
    }
}