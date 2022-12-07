int a;
int b;

Console.Write($"введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);


Console.Write($"{a} + {b} = {a + b}\n");


if (a > b)
{ Console.WriteLine($"Число {a} больше чем {b}");
}
else if (a == b)
{
Console.WriteLine($"Числа {a} и {b} равны");
}
else
{
Console.WriteLine($"Число {b} больше чем {a}");
}