// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

if ((number < 100) || (number > 999))
    Console.WriteLine("Это не трёх значное число, попробуй еще раз");

else {
    number = (number / 10) % 10 ;
    Console.WriteLine($"Вторая цифра =  {number} ");

}
