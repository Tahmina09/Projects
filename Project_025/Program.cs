// Напиши программу, где вводим три числа, а потом выводим сумму только положительных чисел.

// Console.Clear();
// Console.WriteLine("Введите первое число:");
// int n1= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int n2= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число:");
// int n3= Convert.ToInt32(Console.ReadLine());
// int sum=0;
// if (n1%2==0) sum+=n1;
// if (n2%2==0) sum+=n2;
// if (n3%2==0) sum+=n3;
// Console.WriteLine(sum);

Console.Clear();
Console.WriteLine("Введите три числа:");
int n1= Convert.ToInt32(Console.ReadLine());
int n2= Convert.ToInt32(Console.ReadLine());
int n3= Convert.ToInt32(Console.ReadLine());
int [] sumPositive= {n1, n2, n3};
int sum=0;
for(int i=0; i<sumPositive.Length; i++)
{
    if(sumPositive[i]%2==0)
    {
        sum+=sumPositive[i];
    }
}
Console.WriteLine(sum);