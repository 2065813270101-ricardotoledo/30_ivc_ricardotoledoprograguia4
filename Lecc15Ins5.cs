internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, contPrimos = 0, sumaPares = 0;
        bool primo;

        for (num = 300; num >= 1; num--)
        {
            if (num % 2 == 0)
            {
                sumaPares = sumaPares + num;
            }

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
            }
        }

        Console.WriteLine("Cantidad de primos: " + contPrimos);
        Console.WriteLine("Suma de pares: " + sumaPares);

        Console.ReadKey();
    }
}
