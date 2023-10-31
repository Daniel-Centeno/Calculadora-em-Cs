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
                //limpa a tela
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
                    //soma
                    case "add":
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro número que quer somar");
                        string ans1 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Digite o segundo número que quer somar");
                        string ans2 = Console.ReadLine();
                        Console.Clear();
                        try
                        {
                            double res = Convert.ToDouble(ans1);
                            res += Convert.ToDouble(ans2);
                            Console.WriteLine("O resultado é:");
                            Console.WriteLine(res);
                            Console.ReadLine();
                        }
                        catch{
                            Console.WriteLine("ops, algo deu errado");
                            Console.ReadLine();
                        }
                        break;
                    //subtração
                    case "sub":
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro número que quer subtrair");
                        string sns1 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Digite o segundo número que quer subtrair");
                        string sns2 = Console.ReadLine();
                        Console.Clear();
                        try
                        {
                            double res = Convert.ToDouble(sns1);
                            res -= Convert.ToDouble(sns2);
                            Console.WriteLine("O resultado é:");
                            Console.WriteLine(res);
                            Console.ReadLine();
                        }
                        catch
                        {
                            Console.WriteLine("ops, algo deu errado");
                            Console.ReadLine();
                        }
                        break;
                    //multiplicação
                    case "mul":
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro número que quer multiplicar");
                        string mns1 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Digite o segundo número que quer multiplicar");
                        string mns2 = Console.ReadLine();
                        Console.Clear();
                        try
                        {
                            double res = Convert.ToDouble(mns1);
                            res *= Convert.ToDouble(mns2);
                            Console.WriteLine("O resultado é:");
                            Console.WriteLine(res);
                            Console.ReadLine();
                        }
                        catch
                        {
                            Console.WriteLine("ops, algo deu errado");
                            Console.ReadLine();
                        }
                        break;
                    //divisão
                    case "div":
                        Console.Clear();
                        Console.WriteLine("Digite o primeiro número que quer dividir");
                        string dns1 = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Digite o segundo número que quer dividir");
                        string dns2 = Console.ReadLine();
                        Console.Clear();
                        try
                        {
                            double res = Convert.ToDouble(dns1);
                            res /= Convert.ToDouble(dns2);
                            Console.WriteLine("O resultado é:");
                            Console.WriteLine(res);
                            Console.ReadLine();
                        }
                        catch
                        {
                            Console.WriteLine("ops, algo deu errado");
                            Console.ReadLine();
                        }
                        break;
                    case "ext":
                        //Sai do programa
                        running = false;
                        Console.Clear();
                        Console.WriteLine("Muito obrigado pela preferência, volte sempre!");
                        break;
                    default:
                        //Mensagem de erro, caso a mensagem não  seja reconhecida
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
