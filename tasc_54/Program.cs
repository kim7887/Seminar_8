﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

class Program
{
    static int[,] GetRandomMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];
        Random random = new Random();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = random.Next( 1, 10);
            }
        }

        return matrix ;
    }

    static void PrintMatrix(int[,] matrix )
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    static void SortMatrixRowsDescending(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < matrix.GetLength(1); k++)
                {
                    if (matrix[i, k] > matrix[i, j])
                    {
                        int temp = matrix[i, j];
                        matrix[i, j] = matrix[i, k];
                        matrix[i, k] = temp;
                    }
                }
            }
        }
    }

    static void Main()
    {
        const int Rows = 3;
        const int Columns = 4;

        int[,] myMatrix = GetRandomMatrix(Rows, Columns);

        Console.WriteLine("Исходный массив: ");
        PrintMatrix(myMatrix);
        Console.WriteLine();

        SortMatrixRowsDescending(myMatrix);

        Console.WriteLine("Упорядоченный массив: ");
        PrintMatrix(myMatrix);
    }
}