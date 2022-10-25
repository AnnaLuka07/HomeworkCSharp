// Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. Затем из первой суммы (с максимумами) 
// вычтите вторую сумму(с минимумами)
// Например:
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int Prompt (string message)                      // функция ввода 
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

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
    for (int j = 0; j < columns; j ++)
    {
        int min = 10;
        for (int i = 0; i < rows; i ++)
        {
            if (matr [i,j] < min) min = matr [i,j];
        } 
        sum += min;
    }
    return sum;
}  


int i = Prompt("Введите количество строк: ");
int j = Prompt("Введите количество столбцов: ");
int [,] Matrix = new int [i,j];
FillArray(Matrix);
PrintArray(Matrix);
Console.WriteLine($"Сумма максимальных чисел в каждой строке = {SumMaxNamb(Matrix, i, j)}");
Console.WriteLine($"Сумма минимальных чисел в каждом столбце = {SumMinNamb(Matrix, i, j)}");
int Result = SumMaxNamb(Matrix, i, j) - SumMinNamb(Matrix, i, j);
Console.WriteLine($"Разница между суммой максимальных и минимальных значений = {Result}");
