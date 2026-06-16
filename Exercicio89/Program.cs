Console.WriteLine("Hello, World!");

int somaPositivos = 0;
int qntdNegativos = 0;
for (int i = 1; i <= 50; i++)
{ Console.Write("Digte um valor inteiro: ");
  int num = int.Parse(Console.ReadLine());

    if (num > 0)
    {
        somaPositivos += num;
    }
    else if (num < 0)
    {
        qntdNegativos++;
    }
}
Console.WriteLine("Soma dos números positivos: " + somaPositivos);
Console.WriteLine("Quantidade de valores negativos: " + qntdNegativos);