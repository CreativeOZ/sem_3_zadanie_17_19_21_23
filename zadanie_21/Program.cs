// Программа проверяет пятизначное число на палиндромом.

Console.Clear();

Console.WriteLine("Введите 5ти значное число: ");
string num = Console.ReadLine();
int number = Convert.ToInt32(num);
if (number % 10 == number / 1000 && (number % 100) % 10 == (number/1000)%10)
{
    Console.WriteLine("Это палиндром");

}
else
{
    Console.WriteLine("Не палиндром");
}



