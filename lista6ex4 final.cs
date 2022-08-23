using System;

namespace listas
{
    class lista6ex4
    {
        
        static void Main(string[] args)
        {
            // Declaração de variáveis

            float volume, raio, altura;
            const float pi = 3.14159f;

            // Entrada de dados

            Console.WriteLine("Programa para mostrar o volume de uma lata de óleo!");

            //Console.WriteLine("Digite o valor do volume:");
            //volume = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do raio:");
            raio = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura:");
            altura = Convert.ToSingle(Console.ReadLine());

            // Processamento dos dados

            volume = pi * (float)(Math.Pow(raio, raio)) * altura;
            
            // Saída dos dados

            Console.WriteLine($"O volume da lata é {volume}.");
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();
        }
    }
}