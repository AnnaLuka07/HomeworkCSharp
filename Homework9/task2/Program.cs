// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

Console.Clear();

int Prompt (string message)                      
{
    Console.Write(message);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

int SumNumb (int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return n + SumNumb(m, n-1);
    }
}



int M = Prompt("Введите число М: ");
int N = Prompt("Введите число N: ");
Console.WriteLine(SumNumb (M, N));


