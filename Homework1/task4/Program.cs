// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 2;
if (n < count )
{
    Console.WriteLine("Введите число больше 1");
}
while ( count <= n & count % 2 == 0 )
{
   Console.WriteLine(count);
   count = count + 2; 
}
