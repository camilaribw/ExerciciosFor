Console.WriteLine("Hello, World!");

Console.Write("Digite um número: ");
int n = int.Parse(Console.ReadLine());
int fator = 1;
for (int i = 1; i <= n; i++)
{
  fator *= i;
}
Console.WriteLine("Fatorial = " + fator);