void SqareCalculate(float n)
{
for (float i = 1; i <= n; i++)
{
    System.Console.Write($"{i*i};");

}

}

Console.Write("Tipe N = ");
//Console.WriteLine("Please enter number ");
float n = float.Parse(Console.ReadLine());
SqareCalculate(n);
