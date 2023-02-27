// Доп. задачка:
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10);
    }
    return result;
}

int[] array = GetArray(6);
Console.WriteLine($"Массив: [{String.Join(";", array)}]");

int size = array.Length;
int product = 0;

for (int i = 0; i < size; i++)
{
    product = array[i] * array[size - 1];
    size--;
    array[i] = product;
}

int number = 3;
Array.Resize(ref array, number);
Console.WriteLine($"Новый массив из произведений: [{String.Join(";", array)}]");

