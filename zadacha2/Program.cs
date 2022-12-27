// Задача 2 Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите кординаты X точки 1: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите кординаты Y точки 1: ");
int ya = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите кординаты Z точки 1: ");
int za = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите кординаты X точки 2: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите кординаты Y точки 1: ");
int yb = int.Parse(Console.ReadLine()!);
Console.Clear();
Console.WriteLine("Введите кординаты Z точки 1: ");
int zb = int.Parse(Console.ReadLine()!);
Console.Clear();

double xyz = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между точками: {xyz:f2}");

