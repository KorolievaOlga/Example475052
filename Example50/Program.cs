/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;
Clear();
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
            {
                result[i, j] = new Random().Next(100);
            }
       }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
    WriteLine();
    }
}
WriteLine("Введите число m: ");
int m = int.Parse(ReadLine());
WriteLine("Введите число n: ");
int n = int.Parse(ReadLine());
int[,] array = GetArray(m, n);
PrintArray(array);
WriteLine();
WriteLine("Введите позицию строки: ");
int a = int.Parse(ReadLine());
WriteLine("Введите позицию столбца: ");
int b = int.Parse(ReadLine());
if (a > m || b > n)
{
    WriteLine("Такого числа нет");
}
else 
{
    object c = array.GetValue(a, b);
    WriteLine(c);
}

