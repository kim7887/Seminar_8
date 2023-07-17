// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

int rows = 2;
int colums = 4;

int[,] ar1 = new int[rows, colums];
int[,] ar2 = new int[rows, colums];

void InitArray(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int k = 0; k < tempArray.GetLength(1); k++)
        {
            tempArray[i, k] = Random.Shared.Next(1, 10);
        }
    }
}

void PrintArray(int[,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int k = 0; k < tempArray.GetLength(1); k++)
        {
            Console.Write(tempArray[i, k] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] ArrayX(int[,] arrayFirst, int[,] arraySecond) {
    int[,] arrayX = new int[rows, colums];

    for (int i = 0; i < arrayFirst.GetLength(0); i++) {
        for (int k = 0; k < arrayFirst.GetLength(1); k++) {
            arrayX[i, k] = arrayFirst[i, k] * arraySecond[i, k];
        }
    }
    return arrayX;

}

InitArray(ar1);
InitArray(ar2);

PrintArray(ar1);
Console.WriteLine();
PrintArray(ar2);
Console.WriteLine();
PrintArray(ArrayX(ar1, ar2));// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
