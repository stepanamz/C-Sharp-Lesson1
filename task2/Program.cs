Console.Clear();

Console.WriteLine("Введите первое число");
string firstNumer = Console.ReadLine();
Console.WriteLine("Введите второе число");
string secondNumer = Console.ReadLine();

int firstNumerX = int.Parse(firstNumer);
int secondNumerX = int.Parse(secondNumer);

if (firstNumerX > secondNumerX) {
    Console.WriteLine("max=" + firstNumerX + " min=" + secondNumerX );
}
        else {
        Console.WriteLine("max=" + secondNumerX + " min=" + firstNumerX );
    }