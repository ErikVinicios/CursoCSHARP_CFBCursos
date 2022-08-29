using System;

namespace Aula16
{
    class Program
    {
        static void Main()
        {
            int tempo=0;
            char escolha;

            inicio:

            Console.Clear();

            Console.WriteLine("Belo Horizonte/MG a Vitória/ES");
            Console.WriteLine("Escolha o transporte: [a]Aviao | [c]Carro | [o]Ônibus");
            escolha=char.Parse(Console.ReadLine());

            switch(escolha){
                case 'a':
                case 'A':
                    tempo=50;
                    break;
                case 'c':
                case 'C':
                    tempo=480;
                    break;
                case 'o':
                case 'O':
                    tempo=660;
                    break;
                default:
                    tempo=-1;
                    break;
            }
            if (tempo < 0){
                Console.WriteLine("Transporte Indisponivel");
            }else{
                Console.WriteLine($"Para o transporte escolhido o tempo é: {tempo} minutos");
            }

            Console.WriteLine("Consultar novamente? [s/n]");
            escolha=char.Parse(Console.ReadLine());

            if (escolha=='s' || escolha=='S'){
                goto inicio;
            }else{
                Console.Clear();
                Console.WriteLine("Volte sempre");
            }
        }
    }
}
