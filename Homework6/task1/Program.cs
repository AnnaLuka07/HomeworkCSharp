// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)
// Например: 0, 7, 8, -2, -2 -> 2

int Prompt (string message)                      
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[] InputArray(int Length)                      
{
    int [] array = new int [Length];
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write($" Введите {i+1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int PositiveNumb(int [] array)                    
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









