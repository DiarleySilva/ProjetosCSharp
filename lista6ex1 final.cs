using System;

namespace listas{
    class lista6ex1
    {
        public static void Main(string[] args)
        {
            // Declaração de variáveis

            int a, b;

            // Entrada de dados

            Console.WriteLine("Digite o valor de A:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            b = Convert.ToInt32(Console.ReadLine());

            a = b;
            b = a;

            Console.WriteLine("O valor de A é: {0} \nO valor de B é: {1}", a, b);
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadKey();
        }
    }
}