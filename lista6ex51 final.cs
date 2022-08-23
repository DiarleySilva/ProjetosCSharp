using System;

namespace listas
{
    class lista6ex51
    {
        
        static void Main(string[] args)
        {
            // Declaração de variáveis

            float litros, litros_carro, distancia, tempo, velocidade;
            string modelo_carro;
            
            // Entrada de dados

            //Console.Title = "Lista 6 - Exercicio 5.1";
            
            Console.WriteLine("Calculo de combustivel gasto em uma viagem!");

            Console.WriteLine("Qual é a marca e/ou modelo do seu carro?");
            modelo_carro = (Console.ReadLine());

            Console.WriteLine("Quantos litros de combustivel seu carro consome?");
            litros_carro = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o tempo gasto em horas na viagem:");
            tempo = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite a velocidade média da viagem em m/s:");
            velocidade = Convert.ToSingle(Console.ReadLine());

            // Processamento dos dados

            velocidade = (float)(velocidade * 3.6);
            distancia = tempo * velocidade;
            litros = distancia / litros_carro;
            
            // Saída dos dados

            Console.WriteLine($"Seu carro é um(a) {modelo_carro} e gasta {litros_carro} litros por k/m.");
            Console.WriteLine($"A velocidade média foi de {velocidade} km/h.\nO tempo gasto foi de {tempo} horas.\nA distância foi de {distancia}km.");
            Console.WriteLine($"A quantidade de litros consumidos foi de {0:00} litros.", litros);
            Console.WriteLine("\nPressione uma tecla para sair...");
            Console.ReadKey();
        }
    }
}