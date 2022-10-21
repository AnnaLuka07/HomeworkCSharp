// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Например:
// [3 7 22 2 78] -> 76

void Print(double[] array)                           // функция вывода на экран массива.
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]} ");
    }
}


double Max(double[] array)                            // функция нахождения максимального элемента массива.
{
    double max = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

    }
    return max;
}

double Min(double[] array)                             // функция нахождения минимального элемента массива.
{
    double min = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }

    }
    return min;
}




double [] array = {69, 9, 7, 54, 4, 16};
double max = Max(array);
double min = Min(array);
Print(array);
double result = max - min;
Console.WriteLine($" - разница между минимальным и максимальным значением в данном массиве равна {result}");