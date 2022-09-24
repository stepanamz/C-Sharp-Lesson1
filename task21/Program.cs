// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите координаты X для точки A  ");
double xa = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y для точки A  ");
double ya = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Z для точки A  ");
double za = double.Parse(Console.ReadLine());

Console.Write("\n Введите координаты X для точки B  ");
double xb = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Y для точки B  ");
double yb = double.Parse(Console.ReadLine());
Console.Write("Введите координаты Z для точки B  ");
double zb = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xa-xb, 2) + Math.Pow(ya-yb, 2) + Math.Pow(za-zb, 2));
distance = Math.Round(distance,2);
Console.Write($"\n A({xa},{ya},{za}); B({xb},{yb},{zb}) -> {distance}  ");