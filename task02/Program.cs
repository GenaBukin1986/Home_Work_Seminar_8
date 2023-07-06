// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using static System.Console;
// Метод, который создает двумерный массив случайных чисел
int[,] Matrix(int row = 4, int column = 4, int min = 9, int max = 100)
{
    int[,] matrix = new int[row, column];
    Random rmd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rmd.Next(min, max);
        }
    }
    return matrix;
}
// Метод, который выводит в консоль двумерный массив
void PrintMatrix(int[,] matric)
{
    for (int i = 0; i < matric.GetLength(0); i++)
    {
        for (int j = 0; j < matric.GetLength(1); j++)
        {
            Write($"{matric[i, j]} ");
        }
        WriteLine();
    }
    WriteLine();
}

void PrintMinSumString(int[,] matric)
{
    int[] sum = new int[matric.GetLength(1)];
    int count = 0;
    for (int i = 0; i < matric.GetLength(0); i++)
    {
        int sumstring = 0;
        for (int j = 0; j < matric.GetLength(1); j++)
        {
            sumstring += matric[i, j];
        }
        sum[count] = sumstring;
        count++;
    }
    int index = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[index] > sum[i])
        {
            index = i;
        }
    }
    WriteLine($"Строка с наименьшей суммой элементов: {index + 1} строка");
}

Clear();
int[,] matrix = Matrix();
PrintMatrix(matrix);
PrintMinSumString(matrix);
