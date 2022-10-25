// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Например
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int Prompt (string message)                      // функция ввода 
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillArray (double [,] arr)                       // функция заполнения массива
{
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            arr[i,j] = Convert.ToDouble((new Random().Next(-200,200))/10.0);
        }
    }
    Console.WriteLine();
}

void PrintArray (double [,] arr)                       // функция вывода массива на экран
{
    for (int i = 0; i < arr.GetLength(0); i ++)
    {
        for (int j = 0; j < arr.GetLength(1); j ++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = Prompt("Введите количество строк: ");
int n = Prompt("Введите количество столбцов: ");
double [,] Arr = new double [m,n];
FillArray(Arr);
PrintArray(Arr);