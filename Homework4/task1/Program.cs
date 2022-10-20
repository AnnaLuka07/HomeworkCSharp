// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B (и в нулевую степень).
// Использовать свои функции, не использовать Math.Pow
// Например:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt (string message) // функция ввода
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool validateNumber (int B) // функция проверки правильности числа
{
    if (B < 0)
    {
    Console.WriteLine("Введите положительное число. ");
    return false;
    }   
    return true;
}

int A = Prompt("Введите число A: ");
int B = Prompt("Введите число B: ");

if (!validateNumber(B))
{
    return;
}
else
{
    int power = 1;
    for (int i = 0; i < B; i ++)
    {
        power = power * A;
    }
    Console.WriteLine($"{A} в степени {B} = {power}");
}