// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Например:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int Prompt (string message)                                    // функция ввода 
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}


bool CrossPoint ( double k1, double k2, double b1, double b2 )    // функция пересечения.
{
    if (k1 != k2 )
    {
        double X = (b2 - b1) / (k1 - k2);
        double Y = k1 * X + b1;
        Console.WriteLine($"Точка пересечения прямых ({X};{Y}) ");
        return true;
    }
    else if ( k1 == k2 & b1 != b2 ) 
    {    
        Console.WriteLine("Прямые параллельны, точки пересечения нет.");
        return false;
    }
    else 
    {
        Console.WriteLine("Прямые совпадают, решение имеет бесконечное количество значений. ");
        return false;
    }
}

double k1 = Prompt("Введите первый угловой коэффициент К1: ");
double k2 = Prompt("Введите второй угловой коэффициент К2: ");
double b1 = Prompt("Введите первый свободный коэффициент b1: ");
double b2 = Prompt("Введите второй свободный коэффициент b2: ");

CrossPoint( k1, k2, b1, b2 );
