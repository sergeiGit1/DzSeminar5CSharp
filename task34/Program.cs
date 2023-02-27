
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int[] array = GetArray(5, 100, 999);
System.Console.WriteLine($"Массив: [{String.Join(";", array)}]");

int size = array.Length;
int count = 0;


for (int i = 0; i < size; i++)
{
    int quotient = array[i] % 2;
    if (quotient == 0)
    {
        count++;
    }

}
Console.WriteLine($"Количество четных чисел в массиве: {count}");
