// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();
Console.WriteLine("Введите целое положительное число");
int num = int.Parse(Console.ReadLine());

int count = 1;
Console.Write($" {num} -> ");
while (count <= num-1)
{
    Console.Write($"{Math.Pow(count, 3)}, ");
    count++;
}
    Console.Write($"{Math.Pow(count, 3)}.");
    count++;

