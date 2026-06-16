Console.WriteLine("Hello, World!");



int a = 0, b = 1, c;
Console.Write(a + " " + b + " ");
for (int i = 3; i <= 20; i++)
{
  c = a + b;
  Console.Write(c + " ");
  a = b;
  b = c;
}