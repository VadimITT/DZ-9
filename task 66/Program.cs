Console.WriteLine("Введите начальное число :");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число :");
int number2 = int.Parse(Console.ReadLine());
void NumberSum(int number1, int number2, int sum)
{
    if (number1 > number2)
    {
        Console.WriteLine($"Сумма натуральных элементов {sum}");
        return;
    }
    sum = sum + (number1++);
    NumberSum(number1, number2, sum);
}

NumberSum(number1, number2, 0);
