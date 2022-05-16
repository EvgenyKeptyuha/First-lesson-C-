Console.WriteLine("Введите первое число -> ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число -> ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число -> ");
int c = int.Parse(Console.ReadLine());
int max = a;
if (a > b && b > c)
{
    Console.WriteLine( a + " максимальное число");
}
else if (a > c && c > b)
{
    Console.WriteLine( a + " максимальное число");
}
else if (b > a && a > c)
{
    Console.WriteLine( b + " максимальное число");
}
else if (b > c && c > a)
{
    Console.WriteLine( b + " максимальное число");
}
else if (c > b && b > a)
{
    Console.WriteLine( c + " максимальное число");
}
else if (c > a && a > b)
{
    Console.WriteLine( c + " максимальное число");
}