using System;

namespace curso_c_senac
{
    class Retangulo
    {
        static void Main()
        {
            // Declaração das variáveis
            float comprimento = 0, altura = 0;

            // Entrada de dados
            Console.WriteLine("PROGRAMA PARA CALCULAR A ÁREA DE UM RETÁNGULO!");

            Console.WriteLine("Digite o valor do comprimento: ");
            comprimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura: ");
            altura = int.Parse(Console.ReadLine());

            // Saida dos dados
            Console.WriteLine($"A área do retângulo é: {comprimento * altura}.");
            Console.ReadLine();
        } 
    }
}