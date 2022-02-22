// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();

Console.Write("Число х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Число у: ");
int y = int.Parse(Console.ReadLine());
if (x == y*y || y == x*x)
{
    Console.WriteLine("Это квадрат");
}
else
{
    Console.WriteLine("Не квадрат");
}
