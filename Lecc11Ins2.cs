internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("FACTORIALES");
        int num, i;
        long factorial = 1;

        Console.Write("Ingrese un numero entero: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (i = 1; i <= num; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("El factorial es: " + factorial);

        Console.ReadKey();
    }
}