// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
using System;
using static System.Console;

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]}({i},{j},{k})");
            }
            WriteLine();
        }
        WriteLine();
    }
}

int[,,] Array(int a = 2, int b = 2, int c = 2)
{
    int[,,] array = new int[a, b, c];
    int num;
    Random rmd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                while (true)
                {
                    num = rmd.Next(9, 100);
                    if (CheckNumber(array, num)) continue;

                    array[i, j, k] = num;
                    break;
                }


            }
        }
    }
    return array;
}

bool CheckNumber(int[,,] arrs, int number)
{
    for (int i = 0; i < arrs.GetLength(0); i++)
    {
        for (int j = 0; j < arrs.GetLength(1); j++)
        {
            for (int k = 0; k < arrs.GetLength(2); k++)
            {
                if (arrs[i, j, k] == number) return true;
            }
        }
    }
    return false;
}

Clear();
int[,,] matrix = Array();
PrintArray(matrix);