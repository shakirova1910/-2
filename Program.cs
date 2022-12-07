int a;
int b;
int c;
int max;

Console.Write($"введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write($"введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
Console.Write($"введите третье число: ");
int.TryParse(Console.ReadLine()!, out c);


if (b > a)
{ Console.WriteLine($"{b} = max");
}
else if (c > b)
{
Console.WriteLine($"{c}  = max");
}
else if (c > a)
{
Console.WriteLine($"{a}  = max");
}
