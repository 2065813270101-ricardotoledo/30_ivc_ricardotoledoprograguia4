internal class Program
{
    private static void Main(string[] args)
    {
        int num, suma = 0;

        Console.Write("Ingrese un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = num; i >= 1; i--)
        {
            Console.WriteLine(i);
            suma = suma + i;
        }

        Console.WriteLine("Suma total: " + suma);

        Console.ReadKey();
    }
}
