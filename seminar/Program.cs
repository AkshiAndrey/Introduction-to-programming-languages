// See https://aka.ms/new-console-template for more information

//dotnet new console
//dotnet run

Console.WriteLine("Hello, World!");
/*int a; //Целые числа
double b; //Дробные

a = 7;
b = 2.5;

char s1 = 'd'; //Текстовый
char s2 = 'd'; //Текстовый

string s = "Hello world"; // Строковый
*/
//Напишите программу которая на взод принимает число и выдает его квадрат

/*
int a, b;

string userEnter;

Console.Write("Введите число: ");
userEnter = Console.ReadLine()!;

Console.Write(userEnter);

//a = int.Parse(userEnter);
int.TryParse(userEnter, out a);

b = a * a;

Console.Write($"Квадрат введеного числа {b}");
*/

/*
int a;

Console.Write("Введите число: ");

int.TryParse(Console.ReadLine()!, out a);

Console.Write($"Квадрат введеного числа {a * a}");

*/

/*
int a;

Console.Write("Введите число: ");

int.TryParse(Console.ReadLine()!, out a);

if (a > 10)
{
    Console.Write("Получилось");
}
else if (a == 2)
{
    Console.Write("Получилось !");
}
else
{
    Console.Write("Не получилось");
}
*/

int i = 0;

while (i < 10)
{
    Console.Write('!');
    i = i +1;
    // i += 1  i++
}


