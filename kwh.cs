using System;

namespace custo{

    class kwh{

        static void Main()
        {
            decimal watts, dias, horas, kwh;

            Console.WriteLine("Digite o consumo em Watts(W) do aparelho: ");
            watts = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Digite quantas horas o aparelho fica ligado: ");
            horas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite quantos dias do mês o aparelho é ligado:");
            dias = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o custo do Kwh em sua cidade: ");
            kwh = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine($"O consumo é de R${((watts * horas * dias) / 1000 * kwh)} por mês.");
        }
    }
}