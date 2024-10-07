internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Ingrese un número para encontrar todos los números primos hasta ese número:");
        if (int.TryParse(Console.ReadLine(), out int limite))
        {
            Console.WriteLine($"Números primos hasta {limite}:");
            for (int i = 2; i <= limite; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2) return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}