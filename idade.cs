using System;

namespace teste;

    class idade{

        public void Main(String[] args){
            
            int AnoNasc, AnoAtual;

            Console.WriteLine("Digite seu ano de nascimento: ");
            AnoNasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            AnoAtual = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Sua idade é de {AnoNasc - AnoAtual} anos");
        }
    }
