Console.Write("Введите число:");
int chislo = Convert.ToInt32(Console.ReadLine());
if(chislo % 2 == 0)
{
    Console.WriteLine($"Это четное число: {chislo} ");
}
else
{
    Console.WriteLine($"Это нечетное число: {chislo} ");
}
