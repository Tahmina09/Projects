Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32 (Console.ReadLine());
int count = 0;
for (; N!=0; count++)
{
    N/=10;
}
Console.WriteLine(count);