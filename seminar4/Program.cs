int InputNumber() //Ввод целого числа
{
    int _number;
    bool flag;
    while (true)
    {
        flag = int.TryParse(Console.ReadLine()!, out _number);
        if (flag)
        {
            break;
        }
        else
        {
            Console.WriteLine("Не верный ввод.");
            Console.Write("Введите число: ");
        }
    }
    return _number;
}

/*  Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36  */

/*
int A = InputNumber();
int sum = 0;

for (int i = 0; i <= A; i++)
{
    sum += i;
}
Console.WriteLine(sum);*/

/*  Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36  */

/*
int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Сумма чисел от 1 до {a} = {Sum(a)}");

int Sum(int _a)
{
    int sum = 0;
    for (int i = 1; i <= _a; i++)
        sum += i;
    return sum;
}
*/

/*
int G_i = 0;
string G_str = "";

Max(5);

Console.Write($"{G_i} {G_str}");

void Max(int a)
{
    G_i = a;
    if (a > 0)
        G_str = "переменная положительна";
    else if (a < 0)
        G_str = "переменная отрицательна";
    else
        G_str = "переменная равна 0";
    Min(a);
}

void Min(int a)
{
    G_i *= -1;
}
*/

/*     Напишите программу, которая принимает на вход число N 
и выдаёт произведение чисел от 1 до N.
4  -> 24
5  -> 120   */

/*
int N = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

Console.Write($"Произведение чисел от 1 до {N} = {Factorial(N)}");

int Factorial(int _N)
{
    int factorial = 1;
    for (int i = 1; i <= _N; i++)
        factorial *= i;
    return factorial;
}
*/

/*     Напишите функцию, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]   */

/*
int[] array;

array = CreateArray();
for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");

int[] CreateArray()
{
    int[] _array = new int[8];
    for (int i = 0; i < 8; i++)
        _array[i] = new Random().Next(0, 2);
    return _array;
}
*/

/*
nt[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] < array[minPosition]) minPosition = j;
    }
        int temporary = array [i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/

/*
int a = 5;

Console.WriteLine(a);

Multiply(ref a);

Console.WriteLine(a);

void Multiply(ref int _a)
{
    _a *= 2;
}
*/

int[] array = new int[20];

foreach (var item in CreateArray(20))
    Console.Write($"{item} ");

int[] CreateArray(int _size)
{
    int[] _array = new int[_size];
    for (int i = 0; i < _size; i++)
        _array[i] = new Random().Next(10);
    return _array;
}
