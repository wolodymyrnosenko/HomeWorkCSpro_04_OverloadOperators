using System;

namespace HomeWorkCSpro_04_1_Employee_2_City
{
    internal class City
    {

        private string name;
        private int population;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Population
        {
            get { return population; }
            set
            {
                if (value >= 0)
                    population = value;
                else
                    throw new ArgumentException("Чисельність населення не може бути від'ємним.");
            }
        }

        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public static City operator +(City city, int quantity)
        {
            return new City(city.Name, city.Population + quantity);
        }

        public static City operator -(City city, int quantity)
        {
            return new City(city.Name, city.Population - quantity);
        }

        public static bool operator ==(City city1, City city2)
        {
            return city1.Population == city2.Population;
        }

        public static bool operator !=(City city1, City city2)
        {
            return city1.Population != city2.Population;
        }

        public static bool operator >(City city1, City city2)
        {
            return city1.Population > city2.Population;
        }

        public static bool operator <(City city1, City city2)
        {
            return city1.Population < city2.Population;
        }

        public override string ToString()
        {
            return $"Місто: {Name} \tНаселення: {Population}";
        }
    }
}
