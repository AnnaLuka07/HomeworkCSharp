// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, соответствующее дню недели - от 1 до 7");
int weekend = Convert.ToInt32(Console.ReadLine());

if (weekend < 1 | weekend > 7)
{
    Console.WriteLine("Эта цифра не соответствует дням недели.");
}
else if (weekend > 0 & weekend <= 5 )
{
    Console.WriteLine("Это не выходной день.");
}
else
{
    Console.WriteLine("Это выходной день!");
}