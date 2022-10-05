/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

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

Console.WriteLine("Введите число");
int number = InputNumber();

if (number < 100) Console.WriteLine($"В числе {number} третьей цифры нет");

else
{
    int temp = number;
    while (temp > 999) temp /= 10;

    int result = temp % 10;
    Console.WriteLine($"Третьей цифрой числа {number} = {result}");
}

