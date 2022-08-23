using System;

namespace listas
{
    class lista6ex2
    {
        
        static void Main(string[] args)
        {
            // Declaração de variáveis

            float celsius, fahrenheit;

            // Entrada de dados

            Console.WriteLine("Conversor de Celsius para Fahrenheit!");

            Console.WriteLine("Digite a temperatura em graus Celsius:");
            celsius = Convert.ToSingle(Console.ReadLine());

            fahrenheit = (9 * celsius + 160) / 5;

            Console.WriteLine($"O valor da temperatura em graus Celsius convertida para Fahrenheit é {fahrenheit}°F");
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();

        }
        


    }
}