/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int m = 4;
int n = 4;
int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    array[0, i] = i + 1;
    array[i, 3] = i + 4;
    array[3, m - i - 1] = i + 7;
    if (i > 0)
    {
        array[1, i - 1] = i + 11;
    }
}
array[2, 0] = 11;
array[2, 1] = 16;
array[2, 2] = 15;

PrintArray(array);




// Методы.
void PrintArray(int[,] _array)
{
    Console.WriteLine();
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
            if (array[i, j] < 10) Console.Write($"0{_array[i, j]} ");
            else Console.Write($"{_array[i, j]} ");
        Console.WriteLine();
    }
}


