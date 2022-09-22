// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты точки X1: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y1: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z1: ");
int z = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки X2: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координаты точки Z2: ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2-x,2) + Math.Pow(y2-y,2) + Math.Pow(z2-z,2));
Console.WriteLine($"Расстояние между точками равно -> {result:f2}");