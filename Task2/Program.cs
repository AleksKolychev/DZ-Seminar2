Console.Clear();
Console.WriteLine("Введите любое число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 1000)
{
   n = n / 10;
}
if (n < 1000 && n > 99)
    Console.WriteLine(n % 10);
else if (n < 100)
    Console.WriteLine("Третей цифры нет");