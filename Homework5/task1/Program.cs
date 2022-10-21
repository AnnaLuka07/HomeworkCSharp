// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// Например
// [345, 897, 568, 234] -> 2


int[] Fill(int Length)                          // функция рандомного массива
{
    int [] array = new int [Length];
    for (int i = 0; i <= array.Length-1; i ++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}

void Print(int[] array)                      // функция вывода на экран массива.
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($"{array[i]} ");
    }
}

int Even(int[] array)                      // функция подсчета четных чисел.
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}

int [] array = Fill(5);
Print(array);
int amount = Even(array);
Console.WriteLine($" : в массиве {amount} четных чисел.");