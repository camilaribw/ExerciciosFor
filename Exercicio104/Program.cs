Console.WriteLine("Hello, World!");

Console.Write("Digite o primeiro número: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
int b = int.Parse(Console.ReadLine());
int resultado = 0;
for (int i = 1; i <= b; i++)
{
    resultado += a;
}
Console.WriteLine("Resultado = " + resultado);