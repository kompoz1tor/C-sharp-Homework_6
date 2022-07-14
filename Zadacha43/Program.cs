/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

Console.WriteLine("Программа которая ищет точку пересечения двух прямых, заданных уравнениями: ");
Console.WriteLine("y = k1 * x + b1, y = k2 * x + b2;");

Console.WriteLine("Введите значение коофициента b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение коофициента k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение коофициента b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение коофициента k2");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Коофициенты уравнений: {b1} , {k1} , {b2} , {k2}");

// k1*x +b1 = k2*x + b2; k1*x - k2*x = b2 - b1; x(k1 - k1) = b2 - b1; x = (b2-b1)/(k1-k2)
double b = b2 - b1;
double k = k1- k2;
double y = (k1*b2 - k2*b1)/(k1-k2);
double x = b/k;

// y = k1*x +b1; k1*x = y - b1; x = (y - b1)/k1
// y = k2((y - b1)/k1) + b2; y = k2 * ((y/k1 - b1/k1)) + b2;  y = (k1*b2 - k2*b1)/(k1-k2)
// y = k2(x = (y - b1)/k1) + b2
Console.WriteLine("Координаты точки пересечения: " + x + " ; " + y);

