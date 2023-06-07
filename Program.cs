using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 3, 5, 2 },
            { 7, 9, 8 },
            { 4, 6, 9 }
        };

        Console.WriteLine("Прямоугольный массив:");
        PrintMatrix(matrix);

        Console.WriteLine("Индексы силовых точек:");

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        bool hasPowerPoint = false;

        for (int i = 0; i < rows; i++)
        {
            int minInRow = int.MaxValue;
            int columnOfMin = -1;

            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] < minInRow)
                {
                    minInRow = matrix[i, j];
                    columnOfMin = j;
                }
            }

            bool isPowerPoint = true;

            for (int k = 0; k < rows; k++)
            {
                if (matrix[k, columnOfMin] > minInRow)
                {
                    isPowerPoint = false;
                    break;
                }
            }

            if (isPowerPoint)
            {
                hasPowerPoint= true;
                Console.WriteLine($"[{i}, {columnOfMin}]");
            }
        }
        if (hasPowerPoint == false)
            Console.WriteLine("В матрице нет силовых точек");
        Console.ReadLine();
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}