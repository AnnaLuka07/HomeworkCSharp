// Напишите программу, которая заполнит спирально квадратный массив. 

Console.Clear();

int Prompt (string message)                      
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray (int [,] matr)                         
{
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        for (int j = 0; j < matr.GetLength(1); j ++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,] FillArray (int n)                          
{
    int [,] squareMatr = new int [n,n];
    int number = 10;
    for (int m = 0; m < n/2; m ++)
    {
        for (int j = 0; j < n-1-m; j ++)
        {
            squareMatr[m,j] = number;
            number ++;
        }
        for (int i = m; i < n-1-m; i ++)
        {
            squareMatr[i,n-1-m] = number;
            number ++;
        }
        for (int k = n-1-m; k > m; k --)
        {
            squareMatr[n-1-m, k] = number;
            number ++;
        }
        for (int l = n-1-m; l > m; l --)
        {
            squareMatr[l, m] = number;
            number ++;
        }
        if (n % 2 != 0)
        {
            squareMatr[n/2, n/2] = number;
        }
    }
    return squareMatr;
}





int n = Prompt("Введите количество строк и столбцов квадратного массива: ");
if (n <= 1)
{
    Console.WriteLine("Введите размерность массива > 1 ");
}
else
{
    PrintArray(FillArray(n));
}


