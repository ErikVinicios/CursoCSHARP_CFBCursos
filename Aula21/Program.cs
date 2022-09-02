using System;

namespace Aula21
{
    class Program
    {
        static void Main()
        {
           string senha="123";
           string senhauser;
           int tentativas=0;

           do{
            Console.Write("Digite a senha: ");
            senhauser=Console.ReadLine();
            tentativas+=1;
           }while (senha != senhauser);
            
            Console.WriteLine("\nSenha Correta ");
            Console.WriteLine($"Tentativas: {tentativas} ");
        }
    }
}
