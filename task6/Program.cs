

Console.Clear();
Console.WriteLine("Введите число");
string firstNumber = Console.ReadLine();
int firstNumberX = int.Parse(firstNumber);

if (firstNumberX % 2 == 0) {
    Console.WriteLine(firstNumberX + " -> " + "Является четным" );
}
    else {
        Console.WriteLine(firstNumberX + " -> " + "Является НЕ четным" );
    }
