Console.WriteLine("Hello, World!");

int somaPositivos = 0;
int qtdNegativos = 0;
for (int i = 1; i <= 50; i++)
{
    Console.Write("Digite um número: ");
    int numero = int.Parse(Console.ReadLine());
    if (numero > 0)
        somaPositivos += numero;
    else if (numero < 0)
        qtdNegativos++;
} 
Console.WriteLine("Soma dos positivos: " + somaPositivos);
Console.WriteLine("Quantidade de negativos: " + qtdNegativos);