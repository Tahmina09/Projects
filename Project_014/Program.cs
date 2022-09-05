Console.Clear();
Console.WriteLine("Введите число:");
int num=Convert.ToInt32(Console.ReadLine());
if(num % 7==0 && num % 23==0)
{
    
    Console.WriteLine("ДА!");

}
else
{
    Console.WriteLine("НЕТ!");
}