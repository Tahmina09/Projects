// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты А:");
Console.WriteLine("Введите X:");
int xa= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
int ya= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты B:");
Console.WriteLine("Введите X:");
int xb= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y:");
int yb= Convert.ToInt32(Console.ReadLine());

int A= (xb-xa)*(xb-xa);
int B= (yb-ya)*(yb-ya);
int AB= A+B;
double distance= Math.Sqrt(AB);
distance=Math.Round(distance,3);
Console.WriteLine(distance);