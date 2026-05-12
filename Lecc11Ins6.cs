internal class Program
{
    private static void Main(string[] args)
    {
        int num, suma = 0;

        Console.WriteLine("Ingrese numeros (9 para terminar)");

        while (true)
        {
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 9)
            {
                break;
            }

            suma = suma + num;
        }

        Console.WriteLine("La suma es: " + suma);

        Console.ReadKey();
    }
}
