﻿/* З
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Clear();
Console.WriteLine("введите количество строк m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
            Console.WriteLine("");
    }
}
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double arrsum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        arrsum = (arrsum + numbers[i, j]);
    }
    arrsum = arrsum / m;
    Console.Write(arrsum + "; ");
}
Console.WriteLine();

