Console.WriteLine("Hello, World!");

{
    static void Main()
    {
        Console.WriteLine("Número\tQuadrado\tCubo");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{i}\t{i * i}\t\t{i * i * i}");
        }
    }
}