Console.Clear();

Console.WriteLine("Введите первое число");
string firstNumer = Console.ReadLine();
Console.WriteLine("Введите второе число");
string secondNumer = Console.ReadLine();
Console.WriteLine("Введите третье число");
string threeNumer = Console.ReadLine();

int firstNumerX = int.Parse(firstNumer);
int secondNumerX = int.Parse(secondNumer);
int threeNumerX = int.Parse(threeNumer);

int maxNumber = firstNumerX;

if (secondNumerX > maxNumber) { 
    maxNumber=secondNumerX; }

if (threeNumerX > maxNumber){
    maxNumber=threeNumerX;
}

Console.WriteLine("max = " + maxNumber);