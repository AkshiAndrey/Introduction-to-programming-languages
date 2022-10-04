/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/

double InputNumber() //Ввод цисла
{
    double number;
    bool flag;
    while (true)
    {
        flag = double.TryParse(Console.ReadLine()!, out number);
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

double number;

Console.Write ("Введите число: ");
number = InputNumber();

Console.WriteLine(number % 2);

if (number % 2 == 0) Console.WriteLine($"Число {number} четное.");
else Console.WriteLine($"Число {number} нечетное.");



