// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру от 1 до 7, обозначающу день недели");
int number = int.Parse(Console.ReadLine()!);

if ((number > 7) || (number < 1))
        Console.WriteLine($" Не является цифрой обозначающую день недели");

else if (( number == 6) || ( number == 7))
    Console.WriteLine($"{number} - является выходным днем ");

    else {
        Console.WriteLine($"{number} - НЕ является выходным днем ");
    }