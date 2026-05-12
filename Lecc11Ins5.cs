internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2, menor, mayor, suma = 0;

        Console.Write("Ingrese el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else
        {
            menor = num2;
            mayor = num1;
        }

        for (int i = menor; i <= mayor; i++)
        {
            suma = suma + i;
        }

        Console.WriteLine("La suma es: " + suma);

        Console.ReadKey();
    }
}