using System;

namespace HomeWorkCSpro_04_1_Employee
{
    internal class Employee
    {
        private string name;
        private string position;
        private int salary;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    throw new ArgumentException("Зарплата не може бути від'ємною.");
            }
        }

        public Employee(string name, string position, int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public static Employee operator +(Employee employee, int sum)
        {
            return new Employee(employee.Name, employee.Position, employee.Salary + sum);
        }

        public static Employee operator -(Employee employee, int sum)
        {
            return new Employee(employee.Name, employee.Position, employee.Salary - sum);
        }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Salary == employee2.Salary;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Salary != employee2.Salary;
        }

        public static bool operator <(Employee employee1, Employee employee2)
        {
            return employee1.Salary < employee2.Salary;
        }

        public static bool operator >(Employee employee1, Employee employee2)
        {
            return employee1.Salary > employee2.Salary;
        }

        public override string ToString()
        {
            return $"Ім'я: {Name} \tПосада: {Position} \tЗарплата: {Salary} грн";
        }
    }
}
