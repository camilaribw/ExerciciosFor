Console.WriteLine("Hello, World!");


Console.Write("Digite o valor de N: ");
int N = int.Parse(Console.ReadLine());
double A = N;
for (int i = 2; i <= N; i++)
{
    A += (double)(N - i + 1) / i;
}
Console.WriteLine("Valor de A = " + A);