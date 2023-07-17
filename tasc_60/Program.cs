// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int rows = 2;
int colums = 2;
int zeses = 2;

int[,,] arrayX = new int[zeses, rows, colums];


void InitArray(int[,,] temnArray)
{
    for (int n = 0; n < temnArray.GetLength(0); n++)
    {
        for (int i = 0; i < temnArray.GetLength(1); i++)
        {
            for (int m = 0; m < temnArray.GetLength(2); m++)
            {
                temnArray[n, i, m] = Random.Shared.Next(1, 10);
            }
        }
    }
}

void newArray(int[,,] temnArray)
{
    for (int n = 0; n < temnArray.GetLength(0); n++)
    {
        for (int i = 0; i < temnArray.GetLength(0); i++)
        {
            for (int m = 0; m < temnArray.GetLength(1); m++)
            {
                Console.Write($"{temnArray[n, i, m]} ({n},{i},{m}) " );
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

InitArray(arrayX);
newArray(arrayX);