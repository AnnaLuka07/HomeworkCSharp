// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не применять строки!
// Например:
// 14212 -> нет
// 12821 -> да
// Рассматриваю только положительные числа.

int Prompt (string message) // функция ввода
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool validateNumber (int N) // функция проверки правильности числа
{
    if (N < 10000 || N > 99999)
    {
    Console.WriteLine($"Число {N} не пятизначное.");
    return false;
    }   
    return true;
}


int N = Prompt("Введите пятизначное число: ");
int num1 = N;
int num2 = 0;

if (!validateNumber(N))
{
    return;
}
while (num1 > 0)
{
    int last = num1 % 10; // берем последнюю цифру числа N
    num2 = num2 * 10 + last; // ставим ее первой и потом по порядку каждое следующее в перевернутое число, пока цифры не закончатся.
    num1 = num1 / 10; // откидываем использованную последнюю цифру от числа N
}
if (num2 == N)
{
    Console.WriteLine($"Число {N} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {N} не является палиндромом.");
}