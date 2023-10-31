using System;

namespace Calculadora
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // variável que diz se o programa deve ou não ficar ativo
            bool running = true;

            while (running == true)
            {
                Console.Clear();
                //Mensagem de boas vindas / lista de comandos
                Console.WriteLine("Ola! digite a operação que deseja fazer");
                Console.WriteLine("add - soma");
                Console.WriteLine("sub - para subtrair");
                Console.WriteLine("mul - multiplicar");
                Console.WriteLine("div - dividir");
                Console.WriteLine("rai - tira  a raiz do número");
                Console.WriteLine("ext - sair do programa");

                //Guarda a resposta numa string
                string answer = Console.ReadLine();

                switch (answer)
                {
                    case "ext":
                        //Sai do programa
                        running = false;
                        Console.Clear();
                        Console.WriteLine("Muito obrigado pela preferência, volte sempre!");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Desculpe, não entendi muito bem, talvez tenha havido um erro de digitação");
                        Console.WriteLine("Aperte Enter para continuar");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
