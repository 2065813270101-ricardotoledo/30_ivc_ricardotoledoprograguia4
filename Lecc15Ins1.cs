internal class Program
{
    private static void Main(string[] args)
    {
        int tipo, continuar = 1, adultos = 0, ninos = 0;
        double total = 0;

        while (continuar == 1)
        {
            Console.WriteLine("1=Nino 2=Adulto");
            tipo = Convert.ToInt32(Console.ReadLine());

            if (tipo == 1)
            {
                ninos = ninos + 1;
                total = total + 10;
            }
            else if (tipo == 2)
            {
                adultos = adultos + 1;
                total = total + 15;
            }

            Console.WriteLine("Desea ingresar otro boleto? 1=Si 0=No");
            continuar = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Boletos de ninos: " + ninos);
        Console.WriteLine("Boletos de adultos: " + adultos);
        Console.WriteLine("Total cobrado: " + total);

        Console.ReadKey();
    }
}
