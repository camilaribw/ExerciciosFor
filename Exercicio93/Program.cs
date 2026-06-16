Console.WriteLine("Hello, World!");

int graos = 1;
int total = 0;
for (int casa = 1; casa <= 64; casa++)
{
    total += graos;
    graos *= 2;
}
Console.WriteLine("Total de grãos: " + total);