using System;

namespace Aula06
{
    class Program
    {
        static void Main()
        {
            double valorCompra=5.50;
            double valorVenda;
            double lucro=0.1;
            string produto="Pastel";

            valorVenda=valorCompra+(valorCompra*lucro);

            Console.WriteLine($"Produto.......:{produto,15}");
            Console.WriteLine($"Val.Compra....:{valorCompra,15:c}");
            Console.WriteLine($"Lucro.........:{lucro,15:p}");
            Console.WriteLine($"Val.Venda.....:{valorVenda,15:c}");
        }
    }
}
