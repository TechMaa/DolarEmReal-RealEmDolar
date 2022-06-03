using System;
using System.Globalization;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            double precoreal = 0;
            double dolar = 5.33;
            double real = 4.80;
            double precodolar = 0;
            double conversaoreal = 0;
            double conversaodolar = 0;

            Console.WriteLine("OLÁ, SEJA BEM VINDO AO NOSSO CONVERSOR DE MOEDAS\nDIGITE A OPÇÃO DESEJADA DE HOJE");
            Console.WriteLine("CONVERTER: \n(1) - REAL EM DOLAR \n(2) - DOLAR EM REAL");
            n1 = int.Parse(Console.ReadLine());

            if(n1 == 1)
            {
                Console.Write("\nENTRE COM O PREÇO EM REAL: R$");
                precoreal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conversaoreal = precoreal * dolar;

                Console.WriteLine("\nR$" + precoreal.ToString("F2") + " CONVERTIDOS EM DOLAR DA $" + conversaoreal.ToString("F2"));

                Console.WriteLine("\nOBRIGADO PELA PARTICIPAÇÃO");
            }
            else if(n1 == 2)
            {
                Console.Write("\nENTRE COM O PREÇO EM DOLAR: $");
                precodolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conversaodolar = precodolar * real;

                Console.WriteLine("\n$" + precodolar.ToString("F2") + " CONVERTIDOS EM REAIS DA R$" + conversaodolar.ToString("F2"));

                Console.WriteLine("\nOBRIGADO PELA PARTICIPAÇÃO");
            }
            else
            {
                Console.WriteLine("OPÇÃO NÃO IDENTIFICADA !!");
            }

        }
    }
}