internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        bool primo = true;

        Console.Write("Ingrese un numero entero: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            primo = false;
        }
        else
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    primo = false;
                }
            }
        }

        if (primo)
        {
            Console.WriteLine("El numero es primo");
        }
        else
        {
            Console.WriteLine("El numero no es primo");
        }

        Console.ReadKey();

    }
}