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

// Основная функция для поиска элемента
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
    Console.Write($"\n[X]\t");
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
            if (i == elementForColor / arrayToPrint.GetLength(1) &&
                j == elementForColor % arrayToPrint.GetLength(1))
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
            Console.Write(arrayToPrint[i, j] + "\t");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.DarkCyan;
}

int rowForArray = 5;
int columnForArray = 5;
int[,] random2DArray = GetArrayDoubleRandom(rowForArray, columnForArray);

Console.Write($"\nВведите позицию желаемого элемента в двумерном массиве {rowForArray} на {columnForArray}: ");
int position = Convert.ToInt32(Console.ReadLine());
int numberFromArray = FindPositionInArray(random2DArray, position);
Print2DArray(random2DArray, position);

if (position >= random2DArray.Length || position < 0)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"\nВ двумерном массиве {rowForArray} на {columnForArray} позиция {numberFromArray} отсутствует!");
    Console.WriteLine($"Допустимый диапазон от 0 до {random2DArray.Length - 1}!");
    Console.ResetColor();
}
else
{
    Console.WriteLine($"\nНа позиции {position} находится элемент {numberFromArray}");
}