using System;

namespace CalculaJuros
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            float valor = 0;
            int meses = 0;
            float percentual = 0;
            float total = 0;

            Console.WriteLine("Informe o seu valor inicial");
            valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de meses da aplicação");
            meses = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a porcentagem de juros");
            percentual = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe 1 para calcular Juros Simples ou 2 para calcular Juros Composto");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                total = valor + ((valor * (percentual / 100)) * meses);
            }
            else
                if (opcao == 2)
            {
                total = valor;
                while (meses > 0)
                {
                    total = total + (total * (percentual / 100));
                    meses--;
                }
            }
            Console.WriteLine(total);


        }
    }
}