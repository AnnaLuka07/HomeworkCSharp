// Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
// Например: 
// 1 2 5   ->   5 2 1
// 6 1 8        8 6 1

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

void SortArray (int [,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j ++)
    {
        for (int i = 0; i < matr.GetLength(0); i ++)
        {
            int max = matr [i,j];
            for (int k = j+1; k < matr.GetLength(1); k ++)
            {
                if (matr [i,k] >= max)
                {
                    max = matr [i,k];
                    int temp = matr [i,j];
                    matr [i,j] = matr [i,k];
                    matr [i,k] = temp;
                } 
            }
        }
    }
} 
            
int [,] Matrix = new int [3,7];
Console.WriteLine("Задан массив: ");
FillArray(Matrix);
PrintArray(Matrix);
Console.WriteLine("Упорядочим наш массив по убыванию элементов в каждой строке:");
SortArray(Matrix);
PrintArray(Matrix);


