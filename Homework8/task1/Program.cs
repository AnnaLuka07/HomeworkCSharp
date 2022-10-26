

int Prompt (string message)                          // функция ввода 
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void PrintArray (int [,] matr)                         // функция вывода массива на экран
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

void FillArray (int [,] matr)                          // функция заполнения массива
{
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        for (int j = 0; j < matr.GetLength(1); j ++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}

bool  ValidatePosition (int [,] matr, int i, int j)       // функция проверки нахождения элемента в массиве без вывода на печать. Только рассчет. Не работает...
{
    int RowLen = matr.GetLength(0);
    int ColumnsLen = matr.GetLength(1);
    if ( i > 0 & i < RowLen && j > 0 & j < ColumnsLen )
    {
        return true;
    }
    Console.WriteLine("Такого числа нет в массиве");
    return false;
}



int [,] Matrix = new int [5,6];
Console.WriteLine("Задан массив: ");
FillArray(Matrix);
PrintArray(Matrix);
int i = Prompt("Введите номер строки, из которой вы хотите узнать число: ");
int j = Prompt("Введите номер столбца, из которого вы хотите узнать число: ");
if (ValidatePosition(Matrix, i, j))
{
    Console.WriteLine($"Ваше число -> {Matrix[i-1,j-1]}");
}
