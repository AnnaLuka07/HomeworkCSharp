// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
// m = 2, n = 2 -> A(m,n) = 7
// m = 3, n = 7 -> A(m,n) = 1021

// Функция Аккермана для неотрицательных чисел определяется след. образом:
// А (m,n) = n + 1, при m = 0
// А (m,n) = A(m - 1,1) при n = 0, m != 0
// А (m,n) = A(m - 1,A(m, n - 1)), при n > 0, m > 0.

Console.Clear();

int Prompt (string message)                      
{
    Console.Write(message);
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

int Akkerm(int m, int n)
{
    if (m < 0 || n < 0)
    {
        return 0;
    }
    else 
    {
        if (m == 0)
        {
            return n + 1;
        }
        if (n == 0 & m > 0)
        {
            return Akkerm(m - 1, 1);
        }
        if (n > 0 & m > 0)
        {
           return Akkerm(m - 1, Akkerm(m, n -1)); 
        }
        return Akkerm(m, n);
    }
}

int m = Prompt("Введите число m: ");
int n = Prompt("Введите число n: ");
Console.Write($" А({m},{n}) -> ");
Console.WriteLine(Akkerm(m,n));


