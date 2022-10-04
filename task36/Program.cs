/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Task36();

void Task36()
{
    int size = 6;
    int[] array = new int[size];
    FillArrayRandom(array, -10, 20);
    PrintArray(array);
    Console.Write($" -> {FindSumNeChetNumbersArray(array)}");
}

int FindSumNeChetNumbersArray(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        count = count + array[i];
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