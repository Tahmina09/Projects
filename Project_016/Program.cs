Console.WriteLine("Введите 2 числа:");
int x = Convert.ToInt32(Console. ReadLine());
int y = Convert.ToInt32(Console. ReadLine());

if (x==y*y || y==x*x)
{
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("НЕТ!");
}