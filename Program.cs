class Program
{
    static void Main()
    { 
        Console.WriteLine("Digite um número:");
        string entrada = Console.ReadLine();
      
        int numero = Convert.ToInt32(entrada);  
        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }
    }
}
