// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;
using static System.Console;
// Метод, который создает двумерный массив случайных чисел
int[,] Matrix(int row = 4, int column = 4, int min = 1, int max = 20)
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

// Метод, который выводит в консоль две матриы,
// проверяет условия умножения, выводит результат, если условие истинно
void ProductMatrix(int[,] matr1, int[,] matr2)
{
    PrintMatrix(matr1);
    PrintMatrix(matr2);
    if (matr1.GetLength(1) != matr2.GetLength(0))
    {
        WriteLine($"Данные матрицы умножить нельзя");
        return;
    }
    int[,] result = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
            {
                result[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    WriteLine("Результат умножения данных матриц: ");
    WriteLine();
    PrintMatrix(result);
}

// Тестовая часть программы
int[,] matrixone = Matrix(2, 2);
int[,] matrixsecond = Matrix(2, 3);
ProductMatrix(matrixone, matrixsecond);