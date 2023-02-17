using System;

namespace testee
{
    class Program
    {
        static void Main(string[] args)
        {   
            int opçaoNumerica = 5;
            while (opçaoNumerica != 0)
            {
                Console.WriteLine("\n--------------MENU--------------");
                Console.WriteLine(" 1 = Soma \n 2 = Subtração \n 3 = Multiplicação \n 4 = Divisão \n 0 = Sair\n Digite uma opção:");
                Console.WriteLine("--------------------------------");
                opçaoNumerica = Convert.ToInt32(Console.ReadLine());
                if (opçaoNumerica > 4)
                {
                    Console.WriteLine("Opção inválida, tente novamente");
                    continue;
                }
                else if (opçaoNumerica < 0)
                {
                    Console.WriteLine("Opção inválida, tente novamente");
                    continue;
                }
                if (opçaoNumerica == 0)
                {
                    Console.WriteLine("Obrigado por utilizar!");
                    break;
                }
                Console.WriteLine("Primeiro número: ");
                int opçaoUm = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Segundo número: ");
                int opçaoDois = Convert.ToInt32(Console.ReadLine());
                if(opçaoNumerica == 1)
                {
                    int result = opçaoUm + opçaoDois;
                    Console.WriteLine("----------SOMA----------");
                    Console.WriteLine("Seu número é: " + result);
                }
                else if(opçaoNumerica == 2)
                {
                    int result = opçaoUm - opçaoDois;
                    Console.WriteLine("----------SUBTRAÇÃO----------");
                    Console.WriteLine("Seu número é: " + result);
                }
                else if(opçaoNumerica == 3)
                {
                    int result = opçaoUm * opçaoDois;
                    Console.WriteLine("----------MULTIPLICAÇÃO----------");
                    Console.WriteLine("Seu número é: " + result);
                }
                else if(opçaoNumerica == 4)
                {
                    int result = opçaoUm / opçaoDois;
                    Console.WriteLine("----------DIVISÃO----------");
                    Console.WriteLine("Seu número é: " + result);     
                } 
                continue;
            }
        }
    }
}