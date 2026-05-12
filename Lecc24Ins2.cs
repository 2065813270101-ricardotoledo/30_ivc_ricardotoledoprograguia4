internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ingrese un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 2; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadKey();
    }
}
