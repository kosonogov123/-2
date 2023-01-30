Console.Clear();
Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
// int n3 = Convert.ToInt32(n1%n2);

// if (n3==0)
// Console.Write("кратно");
// if (n3<0 || n3>0)
// Console.Write($"не кратно, остаток {n3}");

if (n1 % n2 == 0)
Console.WriteLine("кратно");
else
Console.WriteLine($"не кратно, {n1%n2}");