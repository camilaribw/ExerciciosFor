Console.WriteLine("Hello, World!");

Console.Write("Digite o número de diárias: ");
int diarias = int.Parse(Console.ReadLine());
double taxa, total;
if (diarias < 15)
    taxa = 4.00;
else if (diarias == 15)
    taxa = 3.60;
else
    taxa = 3.00;
total = diarias * (50 + taxa);
Console.WriteLine("Valor total: R$ " + total);