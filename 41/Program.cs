Console.Clear();
int[] array = new int[InputIntNumber()];
EnterArray(array, 0);
PrintArray(array);
CountOfNumBiggerThenZero(array);

int InputIntNumber()
{
        Console.Write("Ведите число: ");
        int number = int.Parse(Console.ReadLine() ?? "0");
        return number;
}

void EnterArray(int[] array, int i)
{

    if (i < array.Length)
    {
        Console.Write($"Введите {i+1} эл-т массива: ");
        array[i] = int.Parse(Console.ReadLine()!);
        i++;
        EnterArray(array, i);
    }
}

void PrintArray(int[] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
        if (i == length - 1)
            Console.WriteLine("]");
        else
            Console.Write(", ");
    }
}

void CountOfNumBiggerThenZero(int[] array)
{
    Random rand = new Random();
    int length = array.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Пользователь ввел {count} чисел больше 0.");
}