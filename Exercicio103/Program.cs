Console.WriteLine("Hello, World!");

Console.Write("Digite a massa inicial: ");
double massa = double.Parse(Console.ReadLine());
int tempo = 0;

while (massa >= 0.05)
{
    massa /= 2;
    tempo += 50;
}
Console.WriteLine("Tempo necessário: " + tempo + " segundos");