using System;

namespace Aula12
{
    class Program
    {
        static void Main()
        {
            int res, n1, n2, n3, n4;
            res=n1=n2=n3=n4=0;
            string resultado="Reprovado";

            Console.Write("Digite a nota 1: ");
            n1=int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 2: ");
            n2=int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 3: ");
            n3=int.Parse(Console.ReadLine());

            Console.Write("Digite a nota 4: ");
            n4=int.Parse(Console.ReadLine());

            res=n1+n2+n3+n4;

            if(res >= 60){
                resultado="Aprovado";
            }
            Console.WriteLine($"Nota: {res} - Resultado: {resultado}");
        }
    }
}
