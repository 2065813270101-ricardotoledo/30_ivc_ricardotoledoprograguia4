internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, contPrimos = 0, suma = 0;
        bool primo;

        for (num = 1; num <= 100; num++)
        {
            primo = true;

            if (num <= 1)
            {
                primo = false;
            }
            else
            {
                for (i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        primo = false;
                    }
                }
            }

            if (primo)
            {
                contPrimos = contPrimos + 1;
                suma = suma + num;
            }
        }

        Console.WriteLine("Cantidad de primos: " + contPrimos);
        Console.WriteLine("Suma de primos: " + suma);

        Console.ReadKey();
    }
}
