// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Напр: 
// 1 2 5 
// 6 8 1  -> Наименьшая сумма элементов в строке 1 (строки считаю с 1)

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

void FillArray (int [,] matr)                          
{
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        for (int j = 0; j < matr.GetLength(1); j ++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}

  
int SumStr (int [,] matr, int str)                 //  расчет суммы по строкам 
{
    int sum = 0;
    for (int j = 0; j < matr.GetLength(1); j ++)
    {
        sum += matr[str,j];
    }
    return sum;
}

int SumMinStr (int[,] matr)                          // ищем строку с наименьшим элементом
{
    int minSum = SumStr(matr,0);
    int findStr = 1;
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        if (SumStr(matr,i) <= minSum)
        {
            minSum = SumStr(matr,i);
            findStr = i+1;
        }
    }
    return findStr;
}



int [,] Matrix = new int [3,5];
Console.WriteLine();
Console.WriteLine("Задан массив: ");
FillArray(Matrix);
PrintArray(Matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов - {SumMinStr(Matrix)}");
Console.WriteLine();

