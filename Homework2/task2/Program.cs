﻿// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// Например:
// 456 -> 46
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число - {a}.");

int temp1 = a / 100;
int temp2 = a % 10;

Console.WriteLine($"Число без второй цифры: {temp1}{temp2}.");

