static int Fact(int x)
{
    for(int i = x-1; i >0; i--)
    {
        x = x * i;
    }
    return x;
}


Console.WriteLine("Enter your number:");
int x=Convert.ToInt32(Console.ReadLine());
for(int i = x; i >=1; i--)
{
    Console.Write(i);
    if(i == 1)
    {
        Console.Write("=");
    }
    else
    {
        Console.Write("x");
    }
}
Console.WriteLine(Fact(x));
