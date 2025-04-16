class Program
{
    static void Main()
    {
        
        Console.WriteLine("Digite um número:");

        
        string entrada = Console.ReadLine();

        int numero = Convert.ToInt32(entrada);

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}
