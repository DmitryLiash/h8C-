Console.Write("Введите первое число:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int n2 = Convert.ToInt32(Console.ReadLine());
if(n1 > n2)
{
    Console.WriteLine($"наибольшее число: {n1} ");
}
else
{
    Console.WriteLine($"наибольшее число: {n2} ");
}
