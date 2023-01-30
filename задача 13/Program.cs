Console.Clear();
Console.WriteLine("Введите число");
int n =Convert.ToInt32(Console.ReadLine());
if (n/100 > 0)
Console.WriteLine((n/10)%10);
else
Console.WriteLine("Третьей цифры нет");