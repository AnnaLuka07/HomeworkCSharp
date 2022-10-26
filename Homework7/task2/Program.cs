// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

 void  ValidatePosition (int [,] matr, int i, int j)       // функция проверки нахождения элемента в массиве и вывод результата
{ 
    int RowLen = matr.GetLength(0);
    int ColumnsLen = matr.GetLength(1);
    if ( i > RowLen | j > ColumnsLen )
    {
        Console.WriteLine("Tакого числа в массиве нет");
    }
    else if ( i <= 0 | j <= 0 )
    {
        Console.WriteLine("Номер строки или столбца не может быть меньше или равно 0. Введите положительное число.");
    }
    else
    {
        Console.WriteLine($"Ваше число -> {matr[i-1,j-1]}");
    }
}  


int [,] Matrix = new int [5,6];
Console.WriteLine("Задан массив: ");
FillArray(Matrix);
PrintArray(Matrix);
int i = Prompt("Введите номер строки, из которой вы хотите узнать число: ");
int j = Prompt("Введите номер столбца, из которого вы хотите узнать число: ");
ValidatePosition(Matrix, i, j);







//bool  ValidatePosition (int [,] matr, int i, int j)       // функция проверки нахождения элемента в массиве без вывода на печать. Только рассчет.
//{
//    int RowLen = matr.GetLength(0);
//    int ColumnsLen = matr.GetLength(1);
//    if ( i > 0 & i < RowLen && j > 0 & j < ColumnsLen )
//    {
//        return true;
//    }
//    Console.WriteLine("Такого числа нет в массиве");
//    return false;
//}