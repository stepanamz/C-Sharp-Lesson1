//  Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int number3 = 0;

if (number<0) 
    number = -number;
if (number<100)
    Console.WriteLine("Третий цифры нету");

else {
    while (number > 1000)
    {
        number=number/10;
    }
    number3 = number%10;
    Console.WriteLine($"Третья цифра заданного числа = {number3}");
}











