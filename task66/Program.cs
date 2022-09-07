﻿/* Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if (m <= n)
    {
        if (m % 2 == 0)
        {
            return m + SumNumbers(m + 2, n);
        }
        else
        {
            m = m + 1;
            return m + SumNumbers(m + 2, n);
        }
    }
    else return 0;
}

Console.WriteLine(SumNumbers(m, n));