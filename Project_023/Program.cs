Console.Clear();
Console.WriteLine("Введите число:");
int N = Convert.ToInt32 (Console.ReadLine());
int multiply=1;
for (int i=1; i<=N; i++)
{
    multiply*=i;
}
Console.WriteLine(multiply);