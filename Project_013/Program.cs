Console.WriteLine("Введите первое число:");
double num1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
double num2= Convert.ToInt32(Console.ReadLine());

if (num1%num2==0)
{
    Console.WriteLine("Кратно.");
}
else
{
    Console.WriteLine("Не кратно. остаток-"+ (num1 % num2));
}