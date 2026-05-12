internal class Program
{
    private static void Main(string[] args)
    {
        int num;

        Console.Write("Ingrese un numero: ");
        num = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }

        Console.ReadKey();
    }
}
