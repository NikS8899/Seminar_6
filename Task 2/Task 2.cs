//  Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем


Console.WriteLine("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются!");
}
else
{
    // Находим X
    double X = (b1 - b2) / (-1 * (k1 - k2));
    // Находим Y
    double Y = k1 * X + b1;

    Console.WriteLine($"Точки пересечения прямых: [{X};{Y}]");
}
