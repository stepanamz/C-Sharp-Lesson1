// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i} эллемент массива: ");
    array[i] = int.Parse(Console.ReadLine());
}


if ((array[0] == array[4]) & (array[1] == array[3]))
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.Write($" -> да ");
}

else
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.Write($" -> нет ");
}
