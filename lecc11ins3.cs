internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("NUMEROS IMPARES DEL 1 AL 100");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }
}