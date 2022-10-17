//Статический двумерный массив

/* **Задача 46:** Задайте двумерный массив размером m×n, заполненный 
случайными целыми числами.
m = 3, n = 4.

1 4 8 19
5 -2 33 -2
77 3 8 1         */

/*
int m = 3, n = 4;

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
*/

/* **Задача 46:** Задайте двумерный массив размером m×n, заполненный 
случайными целыми числами.
m = 3, n = 4.

1 4 8 19
5 -2 33 -2
77 3 8 1         */

/*
int m = 3, n = 4;

int a;

int[,] array = new int[m, n];

CreateArray(ref array);

void CreateArray(ref int[,] _array)
{
    for (int i = 0; i < _array.GetLength(0); i++)
    {
        for (int j = 0; j < _array.GetLength(1); j++)
        {
            _array[i, j] = new Random().Next(10);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
}
*/

/* **Задача 46:** Задайте двумерный массив размером m×n, заполненный 
случайными целыми числами.
m = 3, n = 4.

1 4 8 19
5 -2 33 -2
77 3 8 1         */

/*
int m = 3, n = 4;

int[,] array = CreateArray(m, n);

int[,] CreateArray(int _m, int _n)
{
    int[,] _array = new int[_m, _n];
    for (int i = 0; i < _m; i++)
    {
        for (int j = 0; j < _n; j++)
        {
            _array[i, j] = new Random().Next(10);
            Console.Write($"{_array[i, j]} ");
        }
        Console.WriteLine();
    }
    return _array;
}
*/


// Динамический двумерный список


/*
int m = 3, n = 4;

List<List<int>> list = new List<List<int>>();

for (int i = 0; i < m; i++)
{
    list.Add(new List<int>());
    for (int j = 0; j < n; j++)
    {
        list[i].Add(new Random().Next(10));
    }
}

for (int i = 0; i < m; i++)
{
        for (int j = 0; j < n; j++)
    {
        Console.Write($"{list[i][j]} ");
    }
    Console.WriteLine();
}
*/

/*  **Задача 49:** Задайте двумерный массив. Найдите элементы, у которых оба 
индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть вот так:
1  4 7 2
5 81 2 9
8  4 2 4         */

/*
int m = 3, n = 4;

int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 != 0 && j % 2 != 0)
        {
            array[i, j] *= array[i, j];
        }
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
*/
/*  **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12         */

/*
int m = 4, n = 6;

int[,] array = new int[m, n];

int sum = 0;

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int min = m < n ? m : n;

for (int i = 0; i < min; i++)
{
    sum += array[i, i];
}

Console.Write($"Sum = {sum}");
*/

//Тернарный оператор


