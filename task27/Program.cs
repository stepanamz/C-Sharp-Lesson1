/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Ограничения:
- Должна быть отдельная функция, которая возвразает результат суммы цифр
- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода*/

Console.Clear();
Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine()!);

int Foo(int num)
{
    int result = 0;
    for (int i = 0; i < num; i++)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

int result = Foo(num);
System.Console.WriteLine(result);