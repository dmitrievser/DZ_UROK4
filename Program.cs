/* Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 

Console.WriteLine("Введите число A: ");
double A = int.Parse(Console.ReadLine());

Console.WriteLine("введите число B: ");
double B = int.Parse(Console.ReadLine());

double total = 0;
Console.WriteLine($"А в степени В: {Exp(total)}");

double Exp(double n)
{
    total = Math.Pow(A,B);
    return total;
}

------------------------------------------------------------------------------------------------------

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе {number}: {getsum(number)}");

int getsum (int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + n % 10;
        n /= 10;
    }
    return sum;
}

------------------------------------------------------------------------------------------------------

Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]


int[] array = GetArray(8);

Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetArray(int size)
{
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100);
    }
    return result;
}

*/