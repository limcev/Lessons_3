﻿// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите X1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());

// double x = Math.Pow( x2 - x1, 2);
// double y = Math.Pow( y2 - y1, 2);
double ab = Math.Sqrt(Math.Pow (x2 - x1, 2) + Math.Pow(y2 - y1, 2));
 Console.WriteLine($"{ab:f2}");
