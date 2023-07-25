// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам.

using System;
using static System.Console;

Clear();

string[] array = new string[3];
GetArray(array);
PrintArray(array);

void GetArray(string[] arr)
{
    int i;
    Console.WriteLine("Введите значения массива");
    for (i = 0; i < arr.Length; i++)
        arr[i] = Console.ReadLine()!;
}

void PrintArray(string[] arr)
{
    int i;
    for (i = 0; i < arr.Length; i++)
        Write($"{arr[i]}, ");
}