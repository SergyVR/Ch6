﻿//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1; y = k2 * x + b2

Console.WriteLine("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine());

if (k1 > k2 || k1 < k2 )
{
   double X = Math.Round((b2 - b1) / (k1 - k2)); 
    double Y = Math.Round(k2 * X + b2); 
   Console.WriteLine($"\nТочка пересечения двух прямых имеет координаты: ({X}; {Y})\n"); 
}
else
{
   Console.WriteLine("Прямые не пересекаются, они параллельны");   
} 

