
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Используйте NextDouble().

double[] GetArray(int size)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * 100;
    }
    return result;
}

double[] array = GetArray(5);
Console.WriteLine($"Массив: [{String.Join(";", array)}]");


int size = array.Length;

double max = array[0];
double min = array[0];

for (int i = 0; i < size; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Максимальный элемент: {max}, Минимальный элемент: {min}");
Console.WriteLine($"Разность между максимальным и минимальным элементом массива: {max - min}");

