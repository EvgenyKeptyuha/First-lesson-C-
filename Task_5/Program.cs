﻿Console.WriteLine("Введите целое число N");
int N = int.Parse(Console.ReadLine());
int Y = -N;
while ( Y <= N )
{
    Console.Write(Y + " ");
    Y++;
}