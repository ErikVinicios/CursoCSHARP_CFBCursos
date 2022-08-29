using System;

namespace Aula03
{
    class Program
    {
        static void Main()
        {
            byte n1=1; // 0 à 255
            int num=19;
            char letra='B';
            float valor=5.3f;
            string nome ="Erik";

            var aux=10; // usado quando não se quer especificar o tipo da variável

            Console.WriteLine($"Meu nome é {nome} e eu tenho {num} anos. ");
            Console.WriteLine(n1 + letra + valor + aux);
        }
    }
}