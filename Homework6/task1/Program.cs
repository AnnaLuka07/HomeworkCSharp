// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// Например: 0, 7, 8, -2, -2 -> 2

int Prompt (string message)                      // функция ввода общего количества (М) чисел.
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
 
int[] InputArray(int Length)                      // функция запроса набора отдельных чисел для массива и создание массива. 
{
    int [] array = new int [Length];
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($" Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PositiveNumb(int [] array)                    // функция подсчета положительных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}                 


int M = Prompt("Вы можете ввести несколько чисел. Сколько чисел будете вводить?  ");
int[] arr = InputArray(M);
int result = PositiveNumb(arr);
Console.WriteLine($" Количество положительных чисел -> {result}.");









