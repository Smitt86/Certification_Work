// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из 
// строк, длина которых меньше, либо равна 3 символам.

using System;
using static System.Console;

Clear();

string[] array = new string[3];
GetArray(array);
PrintArray(array);
WriteLine();
NewArray(array);

void GetArray(string[] arr)
{
    Console.WriteLine("Введите значения массива");
    for (int i = 0; i < arr.Length; i++)
        arr[i] = Console.ReadLine()!;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Write($"{arr[i]}, ");
}

void NewArray(string[] array)
{
    string[] arr = new string[array.Length];
    Write("New array: ");
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            arr[i] = array[i];
            Write($"{arr[i]}, ");
        }
}