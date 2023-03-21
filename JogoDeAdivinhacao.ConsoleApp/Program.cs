namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 21);
            int numeroChutado = 0;
            int pontuacao = 1000;
            int totalDeTentativas = 0;

            Console.WriteLine("-------- Jogo de Adivinhação --------\n");
            Console.WriteLine("--- Escolha o nível de dificuldade ---\n");
            Console.WriteLine("(1) Fácil (2) Médio (3) Difícil\n");
            Console.Write(">> Escolha: ");

            string dificuldade = Console.ReadLine();

            // Validação do menu
            while (dificuldade != "1" && dificuldade != "2" && dificuldade != "3")
            {
                Console.Clear();
                Console.WriteLine("-------- Jogo de Adivinhação --------\n");
                Console.WriteLine("--- Opção inválida, escolha novamente ---\n");
                Console.WriteLine("(1) Fácil (2) Médio (3) Difícil\n");
                Console.Write(">> Escolha: ");
                dificuldade = Console.ReadLine();
            }

            switch (dificuldade)
            {
                case "1":
                    totalDeTentativas = 15;
                    break;
                case "2":
                    totalDeTentativas = 10;
                    break;
                case "3":
                    totalDeTentativas = 5;
                    break;
                default:
                    break;
            }

            for (int i = 1; i <= totalDeTentativas; i++)
            {
                Console.Clear();
                Console.WriteLine("-------- Jogo de Adivinhação --------\n");
                Console.WriteLine($">> Tentativa {i} de {totalDeTentativas}\n");
                Console.Write($">> Digite seu chute: ");
                numeroChutado = Convert.ToInt32(Console.ReadLine());

                if (numeroChutado < randomNumber)
                {
                    int randomNumberParaFormula = new Random().Next(100, 200);

                    Console.Clear();
                    Console.WriteLine("-------- Jogo de Adivinhação --------\n");
                    Console.WriteLine(">> Seu chute foi menor que o número secreto!\n");

                    pontuacao -= Math.Abs((numeroChutado - randomNumberParaFormula) / 2);

                    Console.WriteLine($">> Você tem {pontuacao} pontos! \n");
                    Console.WriteLine($">> Pressione qualquer tecla para tentar novamente");
                    Console.ReadKey();
                }

                else if (numeroChutado > randomNumber)
                {
                    int randomNumberParaFormula = new Random().Next(100, 200);

                    Console.Clear();
                    Console.WriteLine("-------- Jogo de Adivinhação --------\n");
                    Console.WriteLine(">> Seu chute foi maior que o número secreto!\n");

                    pontuacao -= Math.Abs((numeroChutado - randomNumberParaFormula) / 2);

                    Console.WriteLine($">> Você tem {pontuacao} pontos! \n");
                    Console.WriteLine($">> Pressione qualquer tecla para tentar novamente");
                    Console.ReadKey();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("-------- Jogo de Adivinhação --------\n");
                    Console.WriteLine("************************************");
                    Console.WriteLine("* Você encontrou o número secreto! *");
                    Console.WriteLine($"*        Sua pontuação: {pontuacao}        *");
                    Console.WriteLine("************************************\n");
                    break;
                }
                
                Console.WriteLine();
                Console.WriteLine(">> Acabaram suas tentativas!");
                Console.WriteLine(">> Você perdeu!");

            }
        }
    }
}
