using System;

namespace JogarDados
{
    class Program
    {

        static void Main(string[] args)
        {
            int Jogador1, Jogador2;
            int PontoJ1 = 0, PontoJ2 = 0;

            Console.WriteLine("Digite o nome do Primeiro Jogador: ");
            string pnome = Console.ReadLine();

            Console.WriteLine("Digite o nome do Segundo Jogador: ");
            string snome = Console.ReadLine();

            while (pnome == snome)
            {
                Console.Clear();
                Console.WriteLine("Os nomes não podem ser iguais!");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("Digite o nome do Segundo Jogador: ");
                snome = Console.ReadLine();
            }
            Console.Clear();

            Random random = new Random();

            Console.WriteLine("Digite o número de jogadas. Mínimo 1 - Máximo 5");
            int Jogadas = Convert.ToInt32(Console.ReadLine());

            while (Jogadas <= 0 || Jogadas > 5)
            {
                Console.Clear();
                Console.WriteLine("Há limite de Jogadas! Digite um valor entre 1 (Hum) e 5 (Cinco).");
                Jogadas = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Jogadas; i++)
            {
                Console.WriteLine("Precione qualquer tecla para jogar o dado. ");
                Console.WriteLine(Environment.NewLine);
                Console.ReadKey();

                Jogador1 = random.Next(1, 6);

                Console.WriteLine(pnome + " tirou: " + Jogador1);
                Console.WriteLine(Environment.NewLine);

                Jogador2 = random.Next(1, 6);
                Console.WriteLine(snome + " tirou: " + Jogador2);
                Console.WriteLine(Environment.NewLine);

                if (Jogador1 > Jogador2)
                {
                    PontoJ1++;
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine(pnome + " ganhou esse Round!");
                }
                else if(Jogador2 > Jogador1)
                {
                    PontoJ2++;
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine(snome + " ganhou esse Round!");
                }
                else
                {
                    Console.WriteLine("Empate!");                     
                }

                Console.WriteLine("A pontuação de " + pnome + " é :" + PontoJ1 + ". A de " + snome + " é: " + PontoJ2 + ".");
                Console.WriteLine();
            }

            if (PontoJ1 > PontoJ2)
            {
                Console.WriteLine(pnome + " Ganhou!");
            }
            else if (PontoJ2 > PontoJ1)
            {
                Console.WriteLine(snome + " Ganhou!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }

            Console.ReadKey();
        }
    }
}