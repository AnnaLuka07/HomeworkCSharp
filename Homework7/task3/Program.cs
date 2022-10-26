// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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

void Average(int [,] matr)                  // функция расчета среднего арифметического в каждом столбце.
{
    for (int j = 0; j < matr.GetLength(1); j ++)    
    {
        double sum = 0;                     
        for (int i = 0; i < matr.GetLength(0); i ++)      
        {
            sum += matr[i,j];
        }
        double result = sum / matr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца {j+1} равно: {result}");
    }
}                                


int [,] arr = new int [4,5];
FillArray(arr);
PrintArray(arr);
Average(arr);

