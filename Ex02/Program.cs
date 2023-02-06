// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void СheckLine(double b1, double k1, double b2, double k2)
{
    if (k1 == k2)
    {
        Console.Write(" -> линии не пересекаются");
    }
    else
    {
        double x = Math.Round((b2 - b1) / (k1 - k2), 3);
        double y = Math.Round(k1 * x + b1, 3);
        Console.Write($" -> {x}; {y} (точка пересечения линий)");
    }
}

double InputNumber(string text)
{
    Console.Write(text);
    double number = double.Parse(Console.ReadLine());
    return number;
}

// Ввод данных от пользователя координат первой и второй линий
double b1 = InputNumber("Введите значение b1 : ");
double k1 = InputNumber("Введите значение k1 : ");
double b2 = InputNumber("Введите значение b2 : ");
double k2 = InputNumber("Введите значение k2 : ");

// Вывод точки пересечения линий или их совпадения или параллельности.
СheckLine(b1, k1, b2, k2);