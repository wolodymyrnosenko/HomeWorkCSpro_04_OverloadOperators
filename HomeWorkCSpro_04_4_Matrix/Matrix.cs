using System;

namespace HomeWorkCSpro_04_4_Matrix
{
    internal class Matrix
    {
        private int _rows;
        private int _columns;
        public int Rows
        {
            get { return _rows; }
            private set
            {
                if (value > 0)
                    _rows = value;
            }
        }
        public int Columns
        {
            get { return _columns; }
            private set
            {
                if (value > 0)
                    _columns = value;
            }
        }
        public double[][] Numbers { get; private set; }
        public Matrix(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Numbers = new double[Rows][];
            for(int i = 0; i < Rows; i++)
                Numbers[i] = new double[Columns];
        }
        //Indexator [,]
        public double this[int i, int j]
        {
            get
            {
                return Numbers[i][j];
            }
            set
            {
                Numbers[i][j] = value;
            }
        }

        //Indexator [][]
        public RowClass this[int i]
        {
            get { return new RowClass(this, i); }
        }

    public class RowClass
        {
            private readonly Matrix matrixRowClass;
            private readonly int rowIndex;
            internal RowClass(Matrix matrixRowClass, int rowIndex)
            {
                this.matrixRowClass = matrixRowClass;
                this.rowIndex = rowIndex;
            }
        
            public double this[int j]
            {
                get
                {
                    return matrixRowClass.Numbers[rowIndex][j];
                }
                set
                {
                    matrixRowClass.Numbers[rowIndex][j] = value;
                }
            }
        }

        public void Init()
        {
            Random random = new Random();
            for (int i = 0; i < Rows; i++) 
                for (int j = 0; j < Columns; j++)
                    //Numbers[i][j] = random.Next(1, 10);
                    //this[i,j] = random.Next(1, 10);
                    this[i][j] = random.Next(1, 10);
        }

        public void ConsoleOutPut()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    //Console.Write($"{Numbers[i][j]}\t");
                    Console.Write($"{this[i, j]}\t");
                    //Console.Write($"{this[i][j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static bool IsValidToOperate(Matrix matrix1, Matrix matrix2)
        {
            return matrix1.Rows == matrix2.Rows && matrix1.Columns == matrix2.Columns;
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (!IsValidToOperate(matrix1, matrix2))
                throw new ArgumentException("Matrixes are not valid");
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix2.Rows; i++)
                for (int j = 0; j < matrix2.Columns; j++)
                    result[i][j] = matrix1[i][j] + matrix2[i][j];
            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (!IsValidToOperate(matrix1, matrix2))
                throw new ArgumentException("Matrixes are not valid");
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix2.Rows; i++)
                for (int j = 0; j < matrix2.Columns; j++)
                    result[i][j] = matrix1[i][j] - matrix2[i][j];
            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (!IsValidToOperate(matrix1, matrix2))
                throw new ArgumentException("Matrixes are not valid");
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix2.Rows; i++)
                for (int j = 0; j < matrix2.Columns; j++)
                    result[i][j] = matrix1[i][j] * matrix2[i][j];
            return result;
        }
        public static Matrix operator *(Matrix matrix1, double number)
        {
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);
            for (int i = 0; i < matrix1.Rows; i++)
                for (int j = 0; j < matrix1.Columns; j++)
                    result[i][j] = matrix1[i][j] * number;
            return result;
        }
        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (!IsValidToOperate(matrix1, matrix2))
                throw new ArgumentException("Matrixes are not valid");
            for (int i = 0; i < matrix1.Rows; i++)
                for (int j = 0; j < matrix1.Columns; j++)
                    if (matrix1[i][j] != matrix2[i][j])
                        return false;
            return true;
        }
        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 == matrix2);
        }

        public override string ToString()
        {
            string str = string.Empty;
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                    str += $"{this[i][j]}\t";
                str += Environment.NewLine;
            }
            return str;
        }
    }
}
