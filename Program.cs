using System;
#region 1


Console.WriteLine("Введи число от 1 до 100");
int a = int.Parse(Console.ReadLine());
if (a % 5 == 0 && a % 3 == 0)
{

    Console.WriteLine("FizzBuzz");
}
else if (a % 3 == 0)
{
    Console.WriteLine("Fizz");

}
else if (a % 5 == 0) 
{
    Console.WriteLine("Buzz");

}else if (a> 1 && a< 100)
{
    Console.WriteLine(a);
}

else
{
    Console.WriteLine("Ошибка");
}

#endregion
#region 2
Console.WriteLine("Введи число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введи процент");
int n = int.Parse(Console.ReadLine());
double sum = b * n / 100;
Console.WriteLine("Результат :" + sum);

#endregion
#region 3
Console.Write("Введите первую цифру: ");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите вторую цифру: ");
int digit2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третью цифру: ");
int digit3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите четвертую цифру: ");
int digit4 = Convert.ToInt32(Console.ReadLine());

int number = digit1 * 1000 + digit2 * 100 + digit3 * 10 + digit4;

Console.WriteLine("Число: " + number);
#endregion
#region 4
Console.Write("Введите шестизначное число: ");
string input = Console.ReadLine();
if (input.Length != 6)
{
    Console.WriteLine("Ошибка:введено число неправильной длины.");
    return;
}
Console.Write("Введите номера разрядов для обмена цифр: ");
string swapInput = Console.ReadLine();

if (swapInput.Length != 2 || !char.IsDigit(swapInput[0]) || !char.IsDigit(swapInput[1]))
{
    Console.WriteLine("Ошибка:неверный формат номеров разрядов.");
    return;
}
int index1 = int.Parse(swapInput[0].ToString()) - 1;
int index2 = int.Parse(swapInput[1].ToString()) - 1;

if (index1 < 0 || index1 > 5 || index2 < 0 || index2 > 5)
{
    Console.WriteLine("Ошибка:номер разряда должен быть в диапазоне от 1 до 6.");
    return;
}
char[] digits = input.ToCharArray();
char temp = digits[index1];
digits[index1] = digits[index2];
digits[index2] = temp;

string result = new string(digits);
Console.WriteLine("Результат: " + result);
#endregion
#region 5 
Console.WriteLine("Введи дату дд.мм.гг");
string input1 = Console.ReadLine();

DateTime date = DateTime.ParseExact(input1, "dd.MM.yyyy", null);

string dayOfWeek = date.ToString("dddd");

int month = date.Month;
string season;
switch (month)
{
    case 12:
    case 1:
    case 2:
        season = "Winter";
        break;
    case 3:
    case 4:
    case 5:
        season = "Spring";
        break;
    case 6:
    case 7:
    case 8:
        season = "Summer";
        break;
    case 9:
    case 10:
    case 11:
        season = "Autumn";
        break;
    default:
        season = "Unknown";
        break;
}
Console.WriteLine($"{season} {dayOfWeek}");
#endregion
#region 6
Console.WriteLine("Введите температуру:");
double temp1 = double.Parse(Console.ReadLine());

Console.WriteLine("Выберите тип температуры:");
Console.WriteLine("1. Фаренгейт");
Console.WriteLine("2. Цельсий");

int choice = int.Parse(Console.ReadLine());

double result1;

switch (choice)
{
    case 1:
        result = (temp1 - 32) / 1.8;
        Console.WriteLine("Температура в градусах Цельсия: " + result);
        break;
    case 2:
        result = (temp1 * 1.8) + 32;
        Console.WriteLine("Температура в градусах Фаренгейта: " + result);
        break;
    default:
        Console.WriteLine("Неверный выбор");
        break;
}

#endregion
#region 7 
Console.Write("Введите начало диапазона: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Введите конец диапазона: ");
int end = int.Parse(Console.ReadLine());


if (start > end)
{
    int temp2 = start;
    start = end;
    end = temp;
}

Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");
for (int i = start; i <= end; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.ReadKey();
#endregion