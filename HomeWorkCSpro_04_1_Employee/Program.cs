using System.Text;
using HomeWorkCSpro_04_1_Employee_2_City;

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
            //emp2 = emp2 - 52000;//Exception

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            Console.WriteLine(emp1 == emp2);
            Console.WriteLine(emp1 > emp2);
            Console.WriteLine(emp1 < emp2);

            Console.WriteLine("------------------------------");
            City city1 = new City("Лондон", 8_899_375);
            City city2 = new City("Варшава", 1_865_000);

            city1 = city1 - 9375;
            city2 = city2 + 35000;
            //city2 = city2 - 3500000;//Exception

            Console.WriteLine(city1);
            Console.WriteLine(city2);

            Console.WriteLine(city1 == city2);
            Console.WriteLine(city1 > city2);
            Console.WriteLine(city1 < city2);
        }
    }
}