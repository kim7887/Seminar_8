// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] arr = new int[4, 4];

void SpiralArray(int[,] trempArrayr)
{
    int sum = 1;
    int size = trempArrayr.GetLength(0);
    for (int i = size - 1, j = 0; i > 0; i--, j++)
    {
        for (int n = j; n < i; n++) { trempArrayr[j, n] = sum++; }
        for (int n = j; n < i; n++) { trempArrayr[n, i] = sum++; }
        for (int n = i; n > j; n--) { trempArrayr[i, n] = sum++; }
        for (int n = i; n > j; n--) { trempArrayr[n, j] = sum++; }
    }
}

void PrintArray(int[,] trempArrayr)
{
    for (int i = 0; i < trempArrayr.GetLength(0); i++)
    {
        for (int n = 0; n < trempArrayr.GetLength(1); n++)
        {
            Console.Write(trempArrayr[i, n] + "\t");
        }
        Console.WriteLine();
    }
}

SpiralArray(arr);
PrintArray(arr);