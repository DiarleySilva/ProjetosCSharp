using System;

namespace curso_c_senac{
    class aposentadoria
    {
        static void Main()
        {
            // Declaração das variáveis
            
            int idade;
            string sexo;

            // Entrada dos dados

            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o seu sexo? Digite H para homem e M para mulher.");
            sexo = (Console.ReadLine());

            // Processamento e saída dos dados
            
            if(idade >= 65 && sexo == "h" || idade >= 65 && sexo == "H"){
            Console.WriteLine("Você pode ou já está aposentado!");
            }
            else if(idade < 61 && sexo == "h" || idade < 61 && sexo == "H"){
            Console.WriteLine("Você ainda não pode aposentar!");
            }
            else if(idade >=61 && sexo == "m" || idade < 61 && sexo == "M"){
            Console.WriteLine("Você pode ou já está aposentada!");
            }
            else if(idade < 61 && sexo == "m" || idade < 61 && sexo == "M"){
            Console.WriteLine("Você ainda não pode aposentar!");
            }

            Console.WriteLine("Pressione uma tecla para sair...");
            Console.ReadLine();
        }
    }
}
