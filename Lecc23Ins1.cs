internal class Program
{
    private static void Main(string[] args)
    {
        double pesoManzana, total = 0;

        Console.WriteLine("COMPRA DE MANZANAS (1 kilo = 1000 gramos)");

        while (total < 1000)
        {
            Console.Write("Ingrese el peso de la manzana en gramos: ");
            pesoManzana = Convert.ToDouble(Console.ReadLine());

            total = total + pesoManzana;

            Console.WriteLine("Peso acumulado: " + total + " gramos");
        }

        Console.WriteLine("Ya alcanzaste 1 kilo o más de manzanas");
        Console.WriteLine("Total final: " + total + " gramos");

        Console.ReadKey();
    }
}
