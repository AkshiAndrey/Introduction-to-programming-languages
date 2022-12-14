/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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
//Находит разницу между максимальным и минимальным элементов массива.
void FindMinMaxDiff(int[] _array)
{
    int min = _array[0], max = _array[0];
    for (int i = 1; i < _array.Length; i++)
    {
        if (min > _array[i]) min = _array[i];
        if (max < _array[i]) max = _array[i];
    }

    Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max - min}");
}

//Основной код

int[] array = CreateArray(6, 0, 100);
PrintArray(array);
Console.WriteLine();
FindMinMaxDiff(array);
Console.WriteLine();
