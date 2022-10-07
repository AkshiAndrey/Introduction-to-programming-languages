﻿/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int InputNumber() //Ввод целого пятизначного числа
{
    int number;
    bool flag;
    while (true)
    {
        flag = int.TryParse(Console.ReadLine()!, out number);
        if (flag && number < 100000 && number > 9999)
        {
            break;
        }
        else
        {
            Console.WriteLine("Не верный ввод, введите целое пятизначное число.");
            Console.Write("Введите число: ");
        }
    }
    return number;
}

Console.WriteLine("Введите целое пятизначное число");
int number = InputNumber();

if (number / 10000 == number % 10)
{
    if (number % 10000 / 1000 == number % 100 / 10) Console.WriteLine("Чесло является полиндромом");
    else Console.WriteLine("Чесло не является полиндромом");
}
else Console.WriteLine("Чесло не является полиндромом");