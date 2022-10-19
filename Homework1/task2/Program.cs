// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например: 2,3,7 > 7

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
Console.WriteLine($"Максимальное из этих чисел - {max}");
