Console.Write("Введите число : ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число : ");
int b = int.Parse(Console.ReadLine());

AkkermanFunction(a, b);
void AkkermanFunction(int a, int b)
{
    Console.Write(Akkerman(a, b));
}
int Akkerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if (a == 0 && b > 0)
    {
        return Akkerman(a - 1, 1);
    }
    else
    {
        return Akkerman(a, b);
    }
}
