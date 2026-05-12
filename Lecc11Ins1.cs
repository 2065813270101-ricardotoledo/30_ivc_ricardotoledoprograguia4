internal class Program
{
    private static void Main(string[] args)
    {
        int capacidad = 200;
        int autos = 0;

        while (autos < capacidad)
        {
            Console.WriteLine("Cajones disponibles: " + (capacidad - autos));

            Console.WriteLine("Ingrese la cantidad de espacios ocupados");
            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                autos++;
            }
            else
            {
                break;
            }
        }

        if (autos >= capacidad)
        {
            Console.WriteLine("Ya no hay cajones libres");
        }
        else
        {
            Console.WriteLine("Estacionamiento detenido antes de llenarse");
        }

        Console.ReadKey();
    }
}