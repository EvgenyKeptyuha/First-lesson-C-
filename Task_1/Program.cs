Console.Write("Введите первое число a -> ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число b -> ");
int b = int.Parse(Console.ReadLine());
bool result = b * b == a;
Console.WriteLine(result ? "Да" : "Нет");