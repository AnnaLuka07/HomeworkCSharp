// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) 
// вычтите вторую сумму(с минимумами)
// Например:
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

void PrintArray (int [,] matr)                       // функция вывода матрицы на экран
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

void FillArray (int [,] matr)                       // функция заполнения матрицы
{
    for (int i = 0; i < matr.GetLength(0); i ++)
    {
        for (int j = 0; j < matr.GetLength(1); j ++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
    Console.WriteLine();
}


int SumMaxNamb (int [,] matr, int rows, int columns)  // функция рассчета суммы по строкам
{
    int sum = 0;
    for (int i = 0; i < rows; i ++)
    {
        int max = 0;
        for (int j = 0; j < columns; j ++)
        {
            if (matr [i,j] > max) max = matr [i,j];
        } 
        sum += max;
    }
    return sum;
}   

int SumMinNamb (int [,] matr, int rows, int columns)    // функция расчета суммы минимальных значений в столбце
{
    int sum = 0;
    for (int i = 0; i < columns; i ++)
    {
        int min = 10;
        for (int j = 0; j < rows; j ++)
        {
            if (matr [i,j] < min) min = matr [i,j];
        } 
        sum += min;
    }
    return sum;
}  


int [,] Matrix = new int [3,3];
FillArray(Matrix);
PrintArray(Matrix);
Console.WriteLine($"Сумма максимальных чисел в каждой строке = {SumMaxNamb(Matrix, 3, 3)}");
Console.WriteLine($"Сумма минимальных чисел в каждом столбце = {SumMinNamb(Matrix, 3, 3)}");
int Result = SumMaxNamb(Matrix, 3, 3) - SumMinNamb(Matrix, 3, 3);
Console.WriteLine($"Разница между суммой максимальных и минимальных значений = {Result}");
