﻿/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//Основной код
int m = 3, n = 4;
int[,] array = new int[m, n];
double[] resArray = new double[n];

for (int i = 0; i < m; i++) //Генерируем двумерный массив.
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
};

for (int i = 0; i < n; i++) resArray[i] = 0; //Массив для расчета результата.

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++) resArray[j] += array[i, j]; //Находим сумму значений в столбцах.
}

Console.Write("Среднее арифметическое каждого столбца: "); //Вывод среднего арифметического в консоль.
foreach (var item in resArray)
{
    Console.Write($"{Math.Round(item / m, 2)}; ");
}

