internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CORTE DE CABELLO");
        int sellos = 0;

        Console.WriteLine("CUPONERA");

        while (sellos < 8)
        {
            Console.Write("Ingrese cantidad de sellos: ");
            sellos = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Mauricio obtiene un corte gratis");

        Console.ReadKey();
    }
}