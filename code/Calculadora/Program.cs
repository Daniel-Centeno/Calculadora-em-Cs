using System;

namespace Calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // variável que diz se o programa deve ou não ficar ativo
            bool running = true;

            if (running == true)
            {
                //Mensagem de boas vindas
                Console.WriteLine("Ola! digite a operação que deseja fazer");
                Console.WriteLine("add - soma");
                Console.WriteLine("sub - para subtrair");
                Console.WriteLine("mul - multiplicar");
                Console.WriteLine("div - dividir");
                Console.WriteLine("rai - tira  a raiz do número");
                Console.WriteLine("ext - sair do programa");

                string answer = Console.ReadLine();
            }
        }
    }
}
