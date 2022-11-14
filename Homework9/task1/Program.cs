// Задайте значения M и N. Напишите программу, которая выведет все чётные 
// натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

Console.Clear();

int Prompt (string message)                      
{
    Console.Write(message + " > ");
    int numb = Convert.ToInt32(Console.ReadLine());
    return numb;
}

void PrintNumb (int M, int N)
{
    if (M >= N)
    {
        return;
    }
    else 
    {
        if (M % 2 == 0)
        {
            Console.WriteLine(M + " "); 
        }
        else
        {
            Console.WriteLine((M + 1) + " ");
        }
    }
    PrintNumb(M + 2, N);
}


int M = Prompt("Введите число М: ");
int N = Prompt("Введите число N: ");
Console.WriteLine();
PrintNumb(M, N);