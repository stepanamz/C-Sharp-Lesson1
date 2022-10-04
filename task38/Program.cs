/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();
Task38();

void Task38()
{
    int size = 10;
    double[] array = new double[size];
    FillArrayRandomDouble(array);
    PrintArrayDouble(array);
    Console.WriteLine($"\n {array[0]}  -  {array[array.Length-1]}  = {RaznicaMaxMinArray(array)}");
}

double RaznicaMaxMinArray(double[] array)
{
    double raznica = 0;
    raznica = Math.Round(array[0] - array[array.Length-1], 2);
    return raznica;
}

void FillArrayRandomDouble(double[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 20 - 10, 2);
    }
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
            Console.Write(" ]");
        else
            Console.Write(" | ");
    }
}