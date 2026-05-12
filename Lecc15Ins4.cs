   internal class Program
    {
        private static void Main(string[] args)
        {
            int i, mul, suma = 0, pares = 0;

            for (i = 1; i <= 20; i++)
            {
                mul = 7 * i;

                suma = suma + mul;

                if (mul % 2 == 0)
                {
                    pares = pares + 1;
                }
            }

            Console.WriteLine("Sumatoria: " + suma);
            Console.WriteLine("Cantidad de pares: " + pares);

            Console.ReadKey();
        }
    }