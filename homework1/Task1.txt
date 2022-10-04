//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


int InputNumber() //Ввод целого цисла
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

int numberA, numberB;

Console.Write ("Введите первое число: ");
numberA = InputNumber();

Console.Write ("Введите второе число: ");
numberB = InputNumber();

//Console.WriteLine(numberA);
//Console.WriteLine(numberB);

if (numberA > numberB)
{
    Console.WriteLine($"Максимальное число: {numberA}");
}
else if (numberA == numberB)
{
    Console.WriteLine($"Числа равны: {numberA} = {numberB}");
}
else
{
    Console.WriteLine($"Максимальное число: {numberB}");
}


