using System;

namespace curso_c_senac
{
    class Trapezio{
    
        static void Main()
        {
            // Declaração das variáveis

            float base_maior, base_menor, altura, area;

            // Entrada dos dados

            Console.WriteLine("PROGRAMA PARA CALCULAR ÁREA DE UM TRAPÉZIO!");

            Console.WriteLine("Qual o valor da base maior?");
            base_maior = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da base menor?");
            base_menor = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o valor da altura?");
            altura = float.Parse(Console.ReadLine());

            // Processamento dos dados
            area = (base_maior + base_menor) * altura / 2;

            // Saida dos dados
            Console.WriteLine($"A área do trapézio é de: {area} metros quadrados.");
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();
        }
    }
}