/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

//Методы
/*
int InputNumber() //Ввод целого числа
{
    int number;
    bool flag;
    while (true)
    {
        flag = int.TryParse(Console.ReadLine()!, out number);
        if (flag)
        {
            break;
        }
        else
        {
            Console.WriteLine("Не верный ввод, введите целое число.");
            Console.Write("Введите число: ");
        }
    }
    return number;
}
*/

//[DllImport("avifil32.dll")]
//static extern
int[,] CreateArrayMN(int _m, int _n) //Создание двумерного массива размером M, N. значения от 0 до 10, Который не понятно как запустить!!!
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

//Основной код
int m = 4;
int n = 4;
int[,] array = new int[m, n];

array = CreateArrayMN(m, n);

/*
Console.WriteLine($"Введите позицию элемента");
int position = InputNumber();
if ((position / 10 > m) || (position % 10 > n)) Console.WriteLine("Такого числа в массиве нет.");
else Console.WriteLine($"На позиции {position} находится число: {array[position / 10, position % 10]} ");
*/