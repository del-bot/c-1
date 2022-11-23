int max = 0;

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    max = a;
}
else
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine(" Максимальное число = " +max);
