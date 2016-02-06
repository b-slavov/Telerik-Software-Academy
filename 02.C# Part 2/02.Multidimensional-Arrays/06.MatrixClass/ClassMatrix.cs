using System;
using System.Diagnostics;

class MatrixClass
{
    public int[,] matrix;
    public int rows;
    public int columns;
    
    public MatrixClass(int i, int j)
    {
        matrix = new int[i, j];
        rows = i;
        columns = j;
    }

    public int this[int i, int j]
    {
        get { return this.matrix[i, j]; }
        set { this.matrix[i, j] = value; }
    }
    
    public static MatrixClass operator +(MatrixClass first, MatrixClass second)
    {

        MatrixClass third = new MatrixClass(first.rows, second.columns);

        for (int rows = 0; rows < third.rows; rows++)
        {
            for (int columns = 0; columns < third.columns; columns++)
            {
                third[rows, columns] = first[rows, columns] + second[rows, columns];
            }
        }

        return third;
    }
    
    public static MatrixClass operator -(MatrixClass first, MatrixClass second)
    {

        MatrixClass third = new MatrixClass(first.rows, second.columns);

        for (int rows = 0; rows < third.rows; rows++)
        {
            for (int columns = 0; columns < third.columns; columns++)
            {
                third[rows, columns] = first[rows, columns] - second[rows, columns];
            }
        }

        return third;
    }
    
    public static MatrixClass operator *(MatrixClass first, MatrixClass second)
    {
        //Making sure first matrix columns and second matrix rows have the same length. Pop-up will notify in case of mismatch.
        Debug.Assert(first.columns == second.rows);
        {
            MatrixClass third = new MatrixClass(first.rows, second.columns);

            for (int rows = 0; rows < third.columns; rows++)
            {
                for (int columns = 0; columns < first.rows; columns++)
                {
                    int value = 0;

                    for (int modifier = 0; modifier < second.rows; modifier++)
                    {
                        value += first[columns, modifier] * second[modifier, rows];
                    }
                    third[columns, rows] = value;
                }
            }
            return third;
        }
    }
    
    public override string ToString()
    {
        string result = string.Empty;

        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.columns; j++)
            {
                result += this[i, j].ToString().PadLeft(6, ' ');
            }

            result += Environment.NewLine;
        }

        return result;
    }
}

class ClassMatrix
{
    static void Main()
    {
        MatrixClass first = new MatrixClass(5, 5);
        MatrixClass second = new MatrixClass(5, 5);

        Random random = new Random();

        for (int rows = 0; rows < first.rows; rows++)
        {
            for (int columns = 0; columns < first.columns; columns++)
            {
                first[rows, columns] = random.Next(-150, 150);
                second[rows, columns] = random.Next(-150, 150);
            }
        }

        Console.WriteLine("Matrix 1:");
        Console.WriteLine(first);

        Console.WriteLine("Matrix 2:");
        Console.WriteLine(second);

        Console.WriteLine("Result after addition:");
        Console.WriteLine(first + second);

        Console.WriteLine("Result upon substraction:");
        Console.WriteLine(first - second);

        Console.WriteLine("Matrices multiplication:");
        Console.WriteLine(first * second);
    }
}