internal class Program
{
    private static void Main(string[] args)
    {
        int num, i, suma = 0;
        bool primo;

        for (num = 1; num <= 50; num++)
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
                suma = suma + num;
            }
        }

        Console.WriteLine("La suma de los numeros primos es: " + suma);

        Console.ReadKey();
    }
}
