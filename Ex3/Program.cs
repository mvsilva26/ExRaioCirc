using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio do círculo: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double area = 3.14 * (raio * raio);
            Console.WriteLine("O valor da área do círculo é: {0}", area);
            Console.ReadLine();
        }
        
    }
}
