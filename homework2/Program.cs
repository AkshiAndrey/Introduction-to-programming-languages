﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int InputNumber() //Ввод целого числа от 1 до 7
{
    int number;
    bool flag;
    while (true)
    {
        flag = int.TryParse(Console.ReadLine()!, out number);
        if (flag && number > 0 && number < 8)
        {
                break;
        }
        else
        {
            Console.WriteLine("Не верный ввод, введите целое число от 1 до 7.");
            Console.Write ("Введите число: ");
        }
    }   
    return number;
}

Console.WriteLine("Введите число");
int number = InputNumber();

if (number < 6) Console.WriteLine($"День недели {number} не выходной");

else
{
    Console.WriteLine($"День недели {number} выходной");
}

