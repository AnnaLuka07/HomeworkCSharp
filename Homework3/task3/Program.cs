// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Например:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt (string message) // функция ввода
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int N = Prompt("Введите число: ");
for (int i = 1; i <= N; i ++ )
{
    Console.WriteLine(Math.Pow(i,3));
}