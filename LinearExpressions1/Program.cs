﻿using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

Console.WriteLine("Введіть число а: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число b: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число c: ");
double c = double.Parse(Console.ReadLine());
Console.WriteLine("Введіть число d: ");
double d = double.Parse(Console.ReadLine());
double x, y, z, r;
x = (a + 2 * b - c + d) / (c * d) + (a+b)/(c-d) - (a*a)/(b*b);
y = (5 * (a + b) * (c - d)) / ((1.0 / 2) * c) + d * d * (( a * a - b * b)/( b - a));
z = ((Math.Pow((x * x - 2 * x), 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b))/(5*a+3*b);
r = ((1.0 / 2) * a + (3.0 / 4) * b - 7.0 / 5) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
Console.WriteLine("z = " + z);
Console.WriteLine("r = " + r);