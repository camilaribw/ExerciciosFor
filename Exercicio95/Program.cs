Console.WriteLine("Hello, World!");

double somaIdade = 0, somaAltura = 0;
int contIdade = 0, contAltura = 0;

for (int i = 1; i <= 45; i++)
{
    Console.Write("Idade: ");
    int idade = int.Parse(Console.ReadLine());

    Console.Write("Altura: ");
    double altura = double.Parse(Console.ReadLine());

    if (altura < 1.70)
    {
      
        somaAltura += altura;
        contAltura++;
    }
}

Console.WriteLine("Média das idades (<1,70m): " + (somaIdade / contIdade));
Console.WriteLine("Média das alturas (>20 anos): " + (somaAltura / contAltura));