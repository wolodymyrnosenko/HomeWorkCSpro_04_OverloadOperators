namespace HomeWorkCSpro_04_4_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3, 5);
            matrix1.Init();
            matrix1.ConsoleOutPut();
            Console.WriteLine("----------------------------------");
            Matrix matrix2 = new Matrix(3, 5);
            matrix2.Init();
            matrix2.ConsoleOutPut();
            Console.WriteLine("----------------------------------");
            matrix2.Numbers[1][1] = 55;//Although private set there isn't exception, why?
            matrix2[1][2] = 77;
            matrix2.ConsoleOutPut();
            Console.WriteLine("----------------------------------");
            var addMatrix = matrix1 + matrix2;
            addMatrix.ConsoleOutPut();
            Console.WriteLine("----------------------------------");
            var subMatrix = matrix1 - matrix2;
            subMatrix.ConsoleOutPut();
            Console.WriteLine("----------------------------------");
            var multMatrix = matrix1 * matrix2;
            multMatrix.ConsoleOutPut();
            Console.WriteLine("----------------------------------");
            var multNumbetMatrix = matrix1 * 10;
            multNumbetMatrix.ConsoleOutPut();
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Matrixes are equals - {matrix1 == matrix2}");
            Console.WriteLine($"Matrixes are not equals - {matrix1 != matrix2}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(matrix1 + matrix2);
            Console.WriteLine(matrix1);
            Console.WriteLine("----------------------------------");
            Matrix matrix3 = new Matrix(1, 7);
            matrix3.Init();
            try
            {
                Console.WriteLine(matrix3 + matrix2);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(matrix3);
        }
    }
}
