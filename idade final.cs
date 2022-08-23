using System;

namespace curso_c_senac
{
    class idade
    {
        static void Main()
        {
            // Declaração das variáveis
            
            int idade;

            // Entrada dos dados

            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());

            // Processamento e saída dos dados
            
            if(idade >= 18){
            Console.WriteLine("Você é maior de idade!");}
            
            else{
            Console.WriteLine("Você é menor de idade!");}
            
            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadLine();
        }
    }
}