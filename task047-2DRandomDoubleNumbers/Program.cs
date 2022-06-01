/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] GetArrayDoubleRandom(int rowNumber, int colNumber, int deviation)
{
    double[,] result = new double[rowNumber, colNumber];

    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().NextDouble() * deviation * 2 - deviation;
        }
    }

    return result;
}

void Print2DArray(double[,] arrayToPrint)
{
    Console.Write($"[X]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine("\n");
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(Math.Round(arrayToPrint[i, j], 1) + "\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите колличество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество колонок массива: ");
int column = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите коэффициент для рандомных чисел: ");
int dev = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nПолученный массив со случайными вещественными числами от -{dev - 0.1} до {dev - 0.1}: ");
double[,] random2DArray = GetArrayDoubleRandom(row, column, dev);
Print2DArray(random2DArray);