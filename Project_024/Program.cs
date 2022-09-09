Console.Clear();
int [] massive =new int [8];
for (int i=0; i<massive.Length; i++)
{
    massive[i] = new Random().Next(0,2);
    Console.Write(massive[i]);
}