﻿
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(4);
    }
    return result;
}

int[] array = GetArray(6);
Console.WriteLine($"Массив: [{String.Join(";", array)}]");

int size = array.Length;
int sum = 0;

for (int i = 1; i < size; i += 2)
{
    sum += array[i];
}
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях равна: {sum}");


