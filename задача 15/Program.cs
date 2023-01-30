Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 || n > 7)
Console.WriteLine("необходимо от 1 до 7");
else {if (n == 6 || n == 7)
Console.WriteLine("yes");

else 
Console.WriteLine("No");}