using System;

namespace teste;

    class idade{

        public void Main(){
            
            int AnoNasc, AnoAtual;

            Console.WriteLine("Digite seu ano de nascimento: ");
            AnoNasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            AnoAtual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sua idade é de {AnoAtual - AnoNasc} anos.");
        }
    }