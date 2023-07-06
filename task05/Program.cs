// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;
using static System.Console;

void Matrix(int row = 5, int column = 5)
{
    int[,] ulitka = new int[row, column];
    int count = 1;
    int a = 0;
    int b = 1;
    int c = 2;
    while (true)
    {
        for (int i = a; i < a + 1; i++) // первый проход
        {
            for (int j = a; j < ulitka.GetLength(1) - a; j++)
            {
                ulitka[i, j] = count;

                count++;
            }

        }
        if (count > ulitka.GetLength(0) * ulitka.GetLength(1)) break;
        for (int i = ulitka.GetLength(1) - b; i < ulitka.GetLength(1) - a; i++) // второй проход
        {
            for (int j = b; j < ulitka.GetLength(0) - a; j++)
            {
                ulitka[j, i] = count;

                count++;
            }
        }
        if (count > ulitka.GetLength(0) * ulitka.GetLength(1)) break;
        for (int i = ulitka.GetLength(0) - b; i < ulitka.GetLength(0) - a; i++) // третий проход
        {
            for (int j = ulitka.GetLength(1) - c; j >= a; j--)
            {
                ulitka[i, j] = count;
                count++;
            }
        }
        for (int i = a; i < a + 1; i++) // четвертый проход
        {
            for (int j = ulitka.GetLength(0) - c; j > a; j--)
            {
                ulitka[j, i] = count;
                count++;
            }
        }
        a++;
        b++;
        c++;
    }
    PrintMatrix(ulitka);

}

// Метод, который выводит в консоль двумерный массив
void PrintMatrix(int[,] matric)
{
    for (int i = 0; i < matric.GetLength(0); i++)
    {
        for (int j = 0; j < matric.GetLength(1); j++)
        {
            if (matric[i, j] / 10 == 0) Write($"0{matric[i, j]} ");
            else Write($"{matric[i, j]} ");
        }
        WriteLine();
    }
    WriteLine();
}

Clear();
Write("Введите количество строк в матрице: ");
int rows = int.Parse(ReadLine()!);
Write("Введите количество столбцов в матрице: ");
int colums = int.Parse(ReadLine()!);
Matrix(rows, colums);