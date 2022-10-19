// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > -100 & number < 100)
{
    Console.WriteLine("В этом числе третьей цифры нет.");
}
else if (number > 999)
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    Console.WriteLine($"Третья цифра этого числа - {number}.");
}
else
{
    while (number < -999)
    {
        number = number / 10;
    }
    number = number * -1;
    number = number % 10;
    Console.WriteLine($"Третья цифра этого числа - {number}.");
}