Console.WriteLine("Hello, World!");
int numero; int somaPositivos = 0;
int qtdNegativos = 0; 
for (int contador = 1; contador <= 50; contador++) {
    Console.Write("Digite o " + contador + "º número: "); 
    numero = int.Parse(Console.ReadLine()); 
    if (numero > 0) {
        somaPositivos += numero; } 
    else if (numero < 0) {
        qtdNegativos++; } 
}
Console.WriteLine("Soma dos números positivos: " + somaPositivos);
Console.WriteLine("Quantidade de números negativos: " + qtdNegativos);