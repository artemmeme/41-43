// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
double x = 0;
double y = 0;
Console.WriteLine("Напишите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
FindXY(x, b2, b1, k1, k2);
void FindXY(double x, double b2, double b1, double k1, double k2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Координаты точки пересечения - [{x};{y}]");
}
