using System;

namespace laba2Part1
{
    class MyMatrix
    {
        private double[,] matrix;
        public int height { get; }
        public int width { get; }


        public MyMatrix(int rows, int colms)
        {
            matrix = new double[rows, colms];
            this.height = rows;
            this.width = colms;
        }

        public MyMatrix(MyMatrix ob)
        {
            matrix = ob.matrix;
            this.height = ob.height;
            this.width = ob.width;
        }

        public MyMatrix(double[,] arr)
        {

            if (arr.GetLength(0) == arr.GetLength(1))
            {
                matrix = arr;
                this.height = arr.GetLength(0);
                this.width = arr.GetLength(1);

            }
            else
            {
                Console.WriteLine("матрица не квадратная попробуйте пожалуста еще раз");
            }
        }

        public MyMatrix(string[,] ob)
        {
            if (ob.GetLength(0) == ob.GetLength(1))
            {
                matrix = new double[ob.GetLength(0), ob.GetLength(1)];
                this.height = ob.GetLength(0);
                this.width = ob.GetLength(1);
                try
                {
                    for (int i = 0; i < ob.GetLength(0); i++)
                    {
                        for (int j = 0; j < ob.GetLength(1); j++)
                        {
                            matrix[i, j] = double.Parse(ob[i, j]);
                        }
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine("ошибочка");
                }
            }
            else
            {
                Console.WriteLine("матрица не квадратная попробуйте пожалуста еще раз");
            }
        }

        public MyMatrix(string s)
        {

        }

        public double this[int row, int colm]
        {
            set
            {
                if (ok(row, colm))
                {
                    matrix[row, colm] = value;
                }
            }
        }

        private bool ok(int row, int colm)
        {
            if ((row >= 0 & row < matrix.GetLength(0)) && (colm >= 0 & colm < matrix.GetLength(1))) return true;
            return false;

        }
        public void filingOfMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    this.matrix[i, j] = rand.Next(-1, 9);
                }
            }
        }

        public void showMatrix()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public double maxValue()
        {
            double max = matrix[0, 0];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if( matrix[i,j]  > max)
                    {
                        max = matrix[i, j];
                    }


                }
              
            }
            return max;
        }

        public double minValue()
        {
            double max = matrix[0, 0];

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (matrix[i, j] < max)
                    {
                        max = matrix[i, j];
                    }


                }
            }
            return max;
        }
    }
}
