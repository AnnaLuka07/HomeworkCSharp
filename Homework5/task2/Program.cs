// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Например:
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] RandArray(int Length)                          // функция рандомного массива
{
    int [] array = new int [Length];
    for (int i = 0; i <= array.Length-1; i ++)
    {
        array[i] = new Random().Next(0,20);
    }
    return array;
}

void Print(int[] array)                               // функция вывода на экран массива.
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumOdd(int[] array)                              // функция подсчета суммы чисел на неченых позициях в массиве.
{
    int sum = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int [] array = RandArray(6);
Print(array);
int sum = SumOdd(array);
Console.WriteLine($" : cумма элементов, стоящих на нечетных позициях равна {sum}.");