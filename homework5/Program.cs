/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

// Методы массивов
//Заполнние массива
int[] CreateArray(int size, int min = 0, int max = 10)
{
    int[] _array = new int[size];
    for (int i = 0; i < size; i++)
        _array[i] = new Random().Next(min, max);
    return _array;
}
//Вывод массива в консоль
void PrintArray(int[] _array)
{
    Console.Write("[");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.Write("]");
}

//Функция для задачи
//Показывает количество чётных чисел в массиве
void FindEven(int[] _array)
{
    int count = 0;
    foreach (var item in _array)
    {
        if (item % 2 == 0) count++;
    }
    Console.WriteLine($"Количество четных чисел в массиве: {count}");
}

//Основной код

int[] array = CreateArray(6, 100, 1000);
PrintArray(array);
Console.WriteLine();
FindEven(array);
Console.WriteLine();
