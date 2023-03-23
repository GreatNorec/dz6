// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите последовательно индексы b1, k1, b2, k2: ");
string s = Console.ReadLine().Replace(",", "");
int[] array = Array.ConvertAll(s.Split(), int.Parse);

//double x = (array[0] - array[2]) / (array[3] - array[1]); Я искренне не понимаю почему такое несчитает, пришлось разбить
double a =array[0] - array[2];
double b =array[3] - array[1];
double x =a / b;
double y = (x * array[1] + array[0]);

Console.WriteLine($"Точка пересечения (x, y) для двух прямых: {x}; {y}");