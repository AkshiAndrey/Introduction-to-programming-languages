/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

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
            Console.Write ("Введите число: ");
        }
    }   
    return number;
}

int number;

Console.Write ("Введите число: ");
number = InputNumber();

//Console.WriteLine(number % 2);

if (number % 2 != 0) number = number++;

int index = 2;
while (index < number + 1)
{
    Console.Write($"{index} ");
    index += 2;
}



