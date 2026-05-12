internal class Program
{
    private static void Main(string[] args)
    {
        int billete, i, cont100 = 0;
        double total = 0;

        for (i = 1; i <= 1000; i++)
        {
            Console.Write("Ingrese denominacion del billete (20,50,100): ");
            billete = Convert.ToInt32(Console.ReadLine());

            total = total + billete;

            if (billete == 100)
            {
                cont100 = cont100 + 1;
            }
        }

        Console.WriteLine("Cantidad de billetes de 100: " + cont100);
        Console.WriteLine("Total de dinero: " + total);

        Console.ReadKey();
    }
}