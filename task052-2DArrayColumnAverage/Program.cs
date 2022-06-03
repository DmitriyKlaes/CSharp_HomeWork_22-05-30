/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
*/

int[,] Get2DArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.WriteLine($"\nМассив целых чисел {arrayToPrint.GetLength(0)}" +
                                       $" на {arrayToPrint.GetLength(1)}:\n");
    Console.Write($"[X]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void AverageOfColumnInArray(int[,] arrayForAverage)
{
    double result = 0;
    for (int j = 0; j < arrayForAverage.GetLength(1); j++)
    {
        for (int i = 0; i < arrayForAverage.GetLength(0); i++)
        {
            result = result + arrayForAverage[i, j];
            if (i == arrayForAverage.GetLength(0) - 1)
            {
                result = result / arrayForAverage.GetLength(0);
                Console.Write($"{Math.Round(result, 1)}");
                if (j < arrayForAverage.GetLength(1) - 1)
                {
                    Console.Write("; ");
                }
                result = 0;
            }
        }
    }
    Console.WriteLine();
}

int rowForArray = 3;
int columnForArray = 4;
int[,] array2DNumbers = Get2DArray(rowForArray, columnForArray);

Print2DArray(array2DNumbers);
Console.Write("\nСреднее арифметическое каждого столбца: ");
AverageOfColumnInArray(array2DNumbers);