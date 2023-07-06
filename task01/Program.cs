// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
// Метод, который сортирует в двумерном массиве числа в строке в порядке убывания
void SortMatrix(int[,] matrik)
{
    for (int i = 0; i < matrik.GetLength(0); i++)
    {

        for (int j = 0; j < matrik.GetLength(1); j++)
        {
            for (int k = j; k < matrik.GetLength(1); k++)
            {
                if (matrik[i, j] < matrik[i, k])
                {
                    int num = matrik[i, j];
                    matrik[i, j] = matrik[i, k];
                    matrik[i, k] = num;
                }
            }
        }
    }
}


Clear();
int[,] matrica = Matrix();
PrintMatrix(matrica);
SortMatrix(matrica);
PrintMatrix(matrica);