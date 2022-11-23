Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int P;
for (P=1; P < N; P++ )
{
    if (P % 2 == 0)
    {
        Console.WriteLine(+P);
    }
}
Console.WriteLine(N);