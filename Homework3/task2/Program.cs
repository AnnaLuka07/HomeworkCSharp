// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Math.Sqrt((x1-x2)^2 + (y1-y2)^2 + (z1-z2)^2) формула нахождения расстояния между точками.

const int X = 0;
const int Y = 1;
const int Z = 2;

int Prompt (string message) // функция ввода
{
    Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int [] InputPoint(int point)
{
    int [] answer = new int [3];
    answer [X] = Prompt($"Введите X{point} -> ");
    answer [Y] = Prompt($"Введите Y{point} -> ");
    answer [Z] = Prompt($"Введите Z{point} -> ");
    return answer;
}

double Power2(int arg)
{
    return arg*arg;
}
int[]p1 = InputPoint(1);
int[]p2 = InputPoint(2);

double lenght = Math.Sqrt(Power2(p1[X] - p2[X]) + (Power2(p1[Y] - p2[Y]) + (Power2(p1[Z] - p2[Z]))));
Console.WriteLine($"{lenght:f2}");