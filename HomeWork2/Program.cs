// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53



Console.WriteLine("Введите X1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());


double ab = Math.Sqrt(Math.Pow (x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
 Console.WriteLine($"{ab:f2}");