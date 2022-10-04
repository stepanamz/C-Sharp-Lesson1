/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

Console.Clear();
Task34();

void Task34()
{
    int size = 6;
    int[] array = new int[size];
    FillArrayRandom(array, 100, 999);
    PrintArray(array);
    Console.Write($" -> {ChetNumbersArray(array)}");
}

int ChetNumbersArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] % 2 == 0)
        {
            count++;
        }

    }
    return count;
}

void FillArrayRandom(int[] array, int minValue = 0, int maxValue = 100)
{
    maxValue++;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
            Console.Write("]");
        else
            Console.Write(", ");
    }
}