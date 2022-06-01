/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
*/

int[,] GetArrayDoubleRandom(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

int FindPositionInArray(int[,] arrayForCheck, int numberPosition)
{
    if (numberPosition >= 0 && numberPosition <= arrayForCheck.Length - 1)
    {
        return arrayForCheck[numberPosition / arrayForCheck.GetLength(1),
                             numberPosition % arrayForCheck.GetLength(1)];
    }
    return numberPosition;
}

void Print2DArray(int[,] arrayToPrint, int elementForColor)
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
            if (i == elementForColor / arrayToPrint.GetLength(1) &&
                j == elementForColor % arrayToPrint.GetLength(1))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            Console.Write(arrayToPrint[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}
System.Console.WriteLine("Введите зазмер двумерного массива: ");
System.Console.Write("Количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите позицию желаемого элемента: ");
int position = Convert.ToInt32(Console.ReadLine());

int[,] random2DArray = GetArrayDoubleRandom(row, column);
int numberFromArray = FindPositionInArray(random2DArray, position);
Print2DArray(random2DArray, position);



Console.ForegroundColor = ConsoleColor.Cyan;
System.Console.WriteLine($"\nВ позиции {position} лежит элемент {numberFromArray}");