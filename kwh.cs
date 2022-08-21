using System;

namespace custo;

    class kwh{

        static void Main(String[] args){
            
            float watts, dias, horas, kwh, consumo;


            Console.WriteLine("Digite o consumo em Watts do aparelho: ");
            watts = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite quantas horas o aparelho fica ligado: ");
            horas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite quantos dias do mês o aparelho é ligado:");
            dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o custo do Kwh em sua cidade: ");
            kwh = Convert.ToInt32(Console.ReadLine());

            consumo = (watts * horas * dias) / 1000 * kwh;

            Console.WriteLine($"O consumo é de R${consumo} por mês.");
        }
    }