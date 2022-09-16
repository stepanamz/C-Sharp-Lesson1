
Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());

int count = 2;
while (count < N+1)
{
    Console.Write(count + ", ");
    count = count + 2;

}
