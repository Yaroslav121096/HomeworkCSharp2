Console.Clear();
Console.WriteLine("Введите день недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.WriteLine("Необходимо ввести цифру от 1 до 7: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("Понедельник не является выходным днём");
else if (n == 2)
    Console.WriteLine("Вторник не является выходным днём");
else if (n == 3)
    Console.WriteLine("Среда не является выходным днём");
else if (n == 4)
    Console.WriteLine("Четверг не является выходным днём");
else if (n == 5)
    Console.WriteLine("Пятница не является выходным днём");
else if (n == 6)
    Console.WriteLine("Суббота является выходным днём");
else if (n == 7)
    Console.WriteLine("Воскресенье является выходным днём");