Console.WriteLine("Hello, World!");


int soma = 0, maior = 0, menor = 0;
for (int i = 1; i <= 10; i++)
{ int n = int.Parse(Console.ReadLine());
  soma += n;
  if (i == 1) maior = menor = n;
  if (n > maior) maior = n;
  if (n < menor) menor = n;
}
Console.WriteLine("Média: " + soma / 10.0);
Console.WriteLine("Maior: " + maior);
Console.WriteLine("Menor: " + menor);