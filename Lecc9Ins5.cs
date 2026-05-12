internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TABLAS DE MULTIPLICAR");
        int num;
        Console.WriteLine("Digite un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
    }
}