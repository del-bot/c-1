﻿int min = 0;
int max = 0;

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    max = a;
    min = b;
}
else
{
   max = b;
   min = a;
}

Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);

