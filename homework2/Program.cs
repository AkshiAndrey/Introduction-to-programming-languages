﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int InputNumber() //Ввод целого трехзначного числа
{
    int number;
    bool flag;
    while (true)
    {
        flag = int.TryParse(Console.ReadLine()!, out number);
        if (flag && number / 100 > 0 && number / 100 < 10)
        {
                break;
        }
        else
        {
            Console.WriteLine("Не верный ввод, введите целое трехзначное число.");
            Console.Write ("Введите число: ");
        }
    }   
    return number;
}

Console.WriteLine("Введите целое трехзначное число");
int number = InputNumber();

int result = number / 10 % 10;
Console.WriteLine($"Второй цифрой числа {number} = {result}");

