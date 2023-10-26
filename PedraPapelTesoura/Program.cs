using System;

namespace PedraPapelTesoura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Jogo Pedra, Papel, Tesoura, lagarto e spock");
                Console.Write("Escolha (Pedra, Papel, Tesoura, lagarto, spock): ");
                string escolhaJogador = Console.ReadLine().ToLower();

                if (escolhaJogador != "pedra" && escolhaJogador != "papel" && escolhaJogador != "tesoura" && escolhaJogador != "lagarto" && escolhaJogador != "spock")
                {
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    continue;
                }

                Random random = new Random();
                int escolhaComputador = random.Next(1, 6); // 1: Pedra, 2: Papel, 3: Tesoura, 4: lagarto, 5: spock

                string escolhaComputadorTexto = "";
                switch (escolhaComputador)
                {
                    case 1:
                        escolhaComputadorTexto = "pedra";
                        break;
                    case 2:
                        escolhaComputadorTexto = "papel";
                        break;
                    case 3:
                        escolhaComputadorTexto = "tesoura";
                        break;
                    case 4:
                        escolhaComputadorTexto = "lagarto";
                        break;
                    case 5:
                        escolhaComputadorTexto = "spock";
                        break;
                }

                Console.WriteLine($"O computador escolheu {escolhaComputadorTexto}");

                if (escolhaJogador == escolhaComputadorTexto)
                {
                    Console.WriteLine("Empate!");
                }
                else if ((escolhaJogador == "pedra" && (escolhaComputadorTexto == "tesoura" || escolhaComputadorTexto == "lagarto")) ||
                         (escolhaJogador == "papel" && (escolhaComputadorTexto == "pedra" || escolhaComputadorTexto == "spock")) ||
                         (escolhaJogador == "tesoura" && (escolhaComputadorTexto == "papel" || escolhaComputadorTexto == "lagarto")) ||
                         (escolhaJogador == "lagarto" && (escolhaComputadorTexto == "spock" || escolhaComputadorTexto == "papel")) ||
                         (escolhaJogador == "spock" && (escolhaComputadorTexto == "tesoura" || escolhaComputadorTexto == "pedra")))
                {
                    Console.WriteLine("Você ganhou!");
                }
                else
                {
                    Console.WriteLine("Você perdeu!");
                }

                Console.Write("Deseja jogar novamente? (s/n): ");
                if (Console.ReadLine().ToLower() != "s")
                {
                    break;
                }
            }
        }
    }
}