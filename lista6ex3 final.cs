using System;

namespace listas
{
    class lista6ex3
    {
        
        static void Main(string[] args)
        {
            // Declaração de variáveis

            float fahrenheit, celsius;

            // Entrada de dados

            Console.WriteLine("Conversor de Fahrenheit para Celsius!");

            Console.WriteLine("Digite a temperatura em graus Fahrenheit:");
            fahrenheit = Convert.ToSingle(Console.ReadLine());

            // Processamento dos dados

            celsius = ((fahrenheit - 32) * 5) /9;

            // Saída dos dados

            Console.WriteLine($"O valor da temperatura em graus Celsius convertida para Fahrenheit é {celsius}°C");
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();
        }
    }
}