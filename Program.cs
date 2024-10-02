

        Random numero = new Random(); // Random cria um gerador de números aletórios
		int b; // Declara uma variável
		//Fase 4: Solicitar o número de dezenas entre 6 e 15
		do
		{
			Console.Write("Quantas dezenas terá seu jogo: "); // Solicita que o usuário insira o valor de dezenas
			string a = Console.ReadLine(); // Para armazenar as dezenas
			b = int.Parse(a); // Lê e converte a entrada do usuário para um número inteiro
			if (b < 6 || b > 15) // Verifica se a quantidade inserida esta fora do intervalo permitido
			{
				Console.WriteLine("Número inválido. Por favor, informe um número entre 6 e 15."); // Solicita que o usuário insira uma dezena válida (entre 6 a 15)
			}
		}
		while (b < 6 || b > 15);
		
		// Fase 3: Solicitar a quantidade de jogos
		Console.Write("Quantos jogos serão: "); // Exibe no console o número de jogos e a quantidade de dezenas por jogo
		string jogo = Console.ReadLine(); // Para armazenar as dezenas sorteadas para o jogo atual
		int c = int.Parse(jogo); // variável
		for (int k = 1; k <= c; k++)
		{
			Console.WriteLine("\n\nJogo de número " + k); // Informa qual jogo é
			for (int i = 1; i <= b; i++) // Informa as dezenas
			{
				int valor = numero.Next(1, 60); // Gera número aleatório entre 1 e 60
				if (i == b)
					Console.Write($"{valor:D2}"); // Gera o ultimo número sem o - 
				else
					Console.Write($"{valor:D2}-"); // Gera os outros números com o - sss
			}
		}

		// Fase 6: Solicitar que o usuário informe o valor do prêmio
		Console.Write("\nInforme o valor do prêmio: ");
		double premio = double.Parse(Console.ReadLine());
		
		// Fase 7: Calcular e distribuir o prêmio
		double premio6Dezenas = premio * 0.75; // Calcula 75% do prêmio total, que séra destinado ao ganhador que acertar 6 dezenas
		double premio5Dezenas = premio * 0.15; // Calcula 15% do prêmio total, que séra destinado ao ganhador que acertar 5 dezenas
		double premio4Dezenas = premio * 0.10; // Calcula 10% do prêmio total, que séra destinado ao ganhador que acertar 4 dezenas
		Console.WriteLine($"\nDistribuição do prêmio:");
		Console.WriteLine($"75% para quem acertar 6 dezenas: R$ {premio6Dezenas:F2}"); //Exibe o valor correspondente a 75% do prêmio
		Console.WriteLine($"15% para quem acertar 5 dezenas: R$ {premio5Dezenas:F2}"); //Exibe o valor correspondente a 15% do prêmio
		Console.WriteLine($"10% para quem acertar 4 dezenas: R$ {premio4Dezenas:F2}"); //Exibe o valor correspondente a 10% do prêmio
	

