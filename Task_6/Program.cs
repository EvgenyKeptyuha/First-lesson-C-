Console.WriteLine("Введите целое число ");
int num = int.Parse(Console.ReadLine());
int ost = num % 2;
if (ost == 0) 
{
    Console.WriteLine(num + " - четное число");
}
else
{
    Console.WriteLine(num + " - нечетное число");
}