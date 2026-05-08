using System;
using System.Threading;

namespace Cadastro_Bandas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            while (opcao != 5)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(@"
██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
                Console.ResetColor();

                Console.WriteLine("\n 1 - Cadastro de Banda");
                Console.WriteLine("\n 2 - Cadastro de Álbum");
                Console.WriteLine("\n 3 - Cadastro de Integrantes");
                Console.WriteLine("\n 4 - Cadastro de Turnês");
                Console.WriteLine("\n 5 - Sair");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Digite a opção escolhida: ");
                Console.ResetColor();

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastroBanda();
                        break;

                    case 2:
                        CadastroAlbum();
                        break;

                    case 3:
                        CadastroIntegrantes();
                        break;

                    case 4:
                        CadastroTurnes();
                        break;

                    case 5:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\nFechando...");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nOpção inválida!!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                }
            }
        }

        static void CadastroBanda()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\nDigite o nome da banda: ");
            string nomeBanda = Console.ReadLine();

            Console.WriteLine("\nDigite o estilo musical da banda: ");
            string estiloBanda = Console.ReadLine();

            Console.WriteLine("\nDigite o ano de criação da banda: ");
            int anoBanda = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o país de origem da banda: ");
            string paisBanda = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nBanda cadastrada com sucesso.");
            Console.ResetColor();

            Thread.Sleep(2000);
        }

        static void CadastroAlbum()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\nDigite o nome do álbum: ");
            string nomeAlbum = Console.ReadLine();

            Console.WriteLine("\nDigite o ano de lançamento do álbum: ");
            int anoAlbum = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a quantidade de músicas do álbum: ");
            int qtdMusicas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdMusicas; i++)
            {
                Console.WriteLine($"\nDigite o nome da música {i}: ");
                string nomeMusica = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nÁlbum cadastrado com sucesso.");
            Console.ResetColor();

            Thread.Sleep(2000);
        }

        static void CadastroIntegrantes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
██╗███╗░░██╗████████╗███████╗░██████╗░██████╗░░█████╗░███╗░░██╗████████╗███████╗░██████╗
██║████╗░██║╚══██╔══╝██╔════╝██╔════╝░██╔══██╗██╔══██╗████╗░██║╚══██╔══╝██╔════╝██╔════╝
██║██╔██╗██║░░░██║░░░█████╗░░██║░░██╗░██████╔╝███████║██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██║██║╚████║░░░██║░░░██╔══╝░░██║░░╚██╗██╔══██╗██╔══██║██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
██║██║░╚███║░░░██║░░░███████╗╚██████╔╝██║░░██║██║░░██║██║░╚███║░░░██║░░░███████╗██████╔╝
╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\nDigite a quantidade de integrantes: ");
            int qtdIntegrantes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdIntegrantes; i++)
            {
                Console.WriteLine($"\nDigite o nome do integrante {i}: ");
                string nomeIntegrante = Console.ReadLine();

                Console.WriteLine($"\nDigite a idade do integrante {i}: ");
                int idadeIntegrante = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nDigite o instrumento ou função do integrante {i}: ");
                string funcaoIntegrante = Console.ReadLine();

                Console.WriteLine($"\nDigite os gostos musicais do integrante {i}: ");
                string gostosIntegrante = Console.ReadLine();
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nIntegrantes cadastrados com sucesso.");
            Console.ResetColor();

            Thread.Sleep(2000);
        }

        static void CadastroTurnes()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(@"
████████╗██╗░░░██╗██████╗░███╗░░██╗███████╗░██████╗
╚══██╔══╝██║░░░██║██╔══██╗████╗░██║██╔════╝██╔════╝
░░░██║░░░██║░░░██║██████╔╝██╔██╗██║█████╗░░╚█████╗░
░░░██║░░░██║░░░██║██╔══██╗██║╚████║██╔══╝░░░╚═══██╗
░░░██║░░░╚██████╔╝██║░░██║██║░╚███║███████╗██████╔╝
░░░╚═╝░░░░╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝╚═════╝░");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.WriteLine("\nDigite o nome da turnê: ");
            string nomeTurne = Console.ReadLine();

            Console.WriteLine("\nDigite a quantidade de países da turnê: ");
            int qtdPaises = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdPaises; i++)
            {
                Console.WriteLine($"\nDigite o país {i} da turnê: ");
                string paisTurne = Console.ReadLine();

                Console.WriteLine($"\nDigite a quantidade de cidades no país {i}: ");
                int qtdCidades = int.Parse(Console.ReadLine());

                for (int j = 1; j <= qtdCidades; j++)
                {
                    Console.WriteLine($"\nDigite o nome da cidade {j}: ");
                    string cidadeTurne = Console.ReadLine();
                }
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nTurnê cadastrada com sucesso.");
            Console.ResetColor();

            Thread.Sleep(2000);
        }
    }
}