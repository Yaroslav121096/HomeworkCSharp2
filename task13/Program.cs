Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int rev = 0;
if (n <= 99)
    Console.WriteLine("Третьей цифры нет!");
while (n > 0)
{
    rev = rev * 10 + n % 10;
    n /= 10;
}
if (rev > 0)
    rev = rev % 1000;
    rev = rev / 100;
    Console.WriteLine(rev);
