// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Функция должна на вход принимать число, а выдавать сумму его цифр
// Например:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Prompt (string message) // функция ввода
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int sumNumber(int num) // функция суммы
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int NegativNum(int num) // функция перевода отрицательного числа в положительное.
{
    if (num < 0)
    {
        num = -num;
    }
    return num;
}


int number = Prompt("Введите число: ");
number = NegativNum(number);

int sum = sumNumber(number);
Console.WriteLine($"Сумма цифр в числе {number} = {sum}.");