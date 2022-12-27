// Задача 3 Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Ведите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Clear();
for (int i = 1; i <= n; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}