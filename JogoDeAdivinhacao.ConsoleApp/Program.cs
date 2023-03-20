namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 20);
            int numeroChutado = 0;
            int pontuacao = 1000;

            Console.WriteLine("-------- Jogo de Adivinhação --------");
            Console.WriteLine();

            Console.WriteLine("--- Escolha o nível de dificuldade ---");
            Console.WriteLine();
            Console.WriteLine("(1) Fácil (2) Médio (3) Difícil");
            Console.WriteLine();
            Console.Write(">> Escolha: ");

            int dificuldade = Convert.ToInt32(Console.ReadLine());

            while (dificuldade != 1 && dificuldade != 2 && dificuldade != 3)
            {
                Console.Clear();
                Console.WriteLine("-------- Jogo de Adivinhação --------");
                Console.WriteLine();
                Console.WriteLine("--- Opção inválida, escolha novamente ---");
                Console.WriteLine();
                Console.WriteLine("(1) Fácil (2) Médio (3) Difícil");
                Console.WriteLine();
                Console.Write(">> Escolha: ");
                dificuldade = Convert.ToInt32(Console.ReadLine());
            }

            if (dificuldade == 1)
            {
                for (int i = 1; i <= 15; i++)
                {
                    Console.Clear();
                    Console.WriteLine("-------- Jogo de Adivinhação --------");
                    Console.WriteLine();
                    Console.WriteLine($">> Tentativa {i} de 15");
                    Console.WriteLine();
                    Console.Write($">> Digite seu chute: ");
                    numeroChutado = Convert.ToInt32(Console.ReadLine());

                    if (numeroChutado < randomNumber)
                    {
                        int randomNumberParaFormula = new Random().Next(50, 100);

                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine(">> Seu chute foi menor que o número secreto!");

                        pontuacao -= Math.Abs((numeroChutado - randomNumberParaFormula) / 2);


                        Console.WriteLine();
                        Console.WriteLine($">> Você tem {pontuacao} pontos! ");
                        Console.WriteLine();
                        Console.WriteLine($">> Pressione qualquer tecla para tentar novamente");
                        Console.ReadKey();
                    }

                    else if (numeroChutado > randomNumber)
                    {
                        int randomNumberParaFormula = new Random().Next(50, 100);

                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine(">> Seu chute foi maior que o número secreto!");

                        pontuacao -= Math.Abs((numeroChutado - randomNumberParaFormula) / 2);


                        Console.WriteLine();
                        Console.WriteLine($">> Você tem {pontuacao} pontos! ");
                        Console.WriteLine();
                        Console.WriteLine($">> Pressione qualquer tecla para tentar novamente");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine("************************************");
                        Console.WriteLine("* Você encontrou o número secreto! *");
                        Console.WriteLine($"*        Sua pontuação: {pontuacao}        *");
                        Console.WriteLine("************************************");
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine(">> Acabaram suas tentativas!");
                    Console.WriteLine(">> Você perdeu!");

                }
            }

            else if (dificuldade == 2)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Clear();
                    Console.WriteLine("-------- Jogo de Adivinhação --------");
                    Console.WriteLine();
                    Console.WriteLine($">> Tentativa {i} de 10");
                    Console.WriteLine();
                    Console.Write($">> Digite seu chute: ");
                    numeroChutado = Convert.ToInt32(Console.ReadLine());

                    if (numeroChutado < randomNumber)
                    {
                        int randomNumberParaFormula = new Random().Next(50, 100);

                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine(">> Seu chute foi menor que o número secreto!");

                        pontuacao -= Math.Abs((numeroChutado - randomNumberParaFormula) / 2);


                        Console.WriteLine();
                        Console.WriteLine($">> Você tem {pontuacao} pontos! ");
                        Console.WriteLine();
                        Console.WriteLine($">> Pressione qualquer tecla para tentar novamente");
                        Console.ReadKey();
                    }

                    else if (numeroChutado > randomNumber)
                    {
                        int randomNumberParaFormula = new Random().Next(50, 100);

                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine(">> Seu chute foi maior que o número secreto!");

                        pontuacao -= Math.Abs((numeroChutado - randomNumberParaFormula) / 2);


                        Console.WriteLine();
                        Console.WriteLine($">> Você tem {pontuacao} pontos! ");
                        Console.WriteLine();
                        Console.WriteLine($">> Pressione qualquer tecla para tentar novamente");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine("************************************");
                        Console.WriteLine("* Você encontrou o número secreto! *");
                        Console.WriteLine($"*        Sua pontuação: {pontuacao}        *");
                        Console.WriteLine("************************************");
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine(">> Acabaram suas tentativas!");
                    Console.WriteLine(">> Você perdeu!");


                }
            }

            else if (dificuldade == 3)
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine("-------- Jogo de Adivinhação --------");
                    Console.WriteLine();
                    Console.WriteLine($">> Tentativa {i} de 5");
                    Console.WriteLine();
                    Console.Write($">> Digite seu chute: ");
                    numeroChutado = Convert.ToInt32(Console.ReadLine());

                    if (numeroChutado < randomNumber)
                    {
                        int randomNumberParaFormula = new Random().Next(50, 100);

                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine(">> Seu chute foi menor que o número secreto!");

                        pontuacao -= Math.Abs((numeroChutado - randomNumberParaFormula) / 2);


                        Console.WriteLine();
                        Console.WriteLine($">> Você tem {pontuacao} pontos! ");
                        Console.WriteLine();
                        Console.WriteLine($">> Pressione qualquer tecla para tentar novamente");
                        Console.ReadKey();
                    }

                    else if (numeroChutado > randomNumber)
                    {
                        int randomNumberParaFormula = new Random().Next(50, 100);

                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine(">> Seu chute foi maior que o número secreto!");

                        pontuacao -= Math.Abs((numeroChutado - randomNumberParaFormula) / 2);


                        Console.WriteLine();
                        Console.WriteLine($">> Você tem {pontuacao} pontos! ");
                        Console.WriteLine();
                        Console.WriteLine($">> Pressione qualquer tecla para tentar novamente");
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.Clear();
                        Console.WriteLine("-------- Jogo de Adivinhação --------");
                        Console.WriteLine();
                        Console.WriteLine("************************************");
                        Console.WriteLine("* Você encontrou o número secreto! *");
                        Console.WriteLine($"*        Sua pontuação: {pontuacao}        *");
                        Console.WriteLine("************************************");
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine(">> Acabaram suas tentativas!");
                    Console.WriteLine(">> Você perdeu! :(");
                    Console.WriteLine();

                }
            }
        }
    }
}