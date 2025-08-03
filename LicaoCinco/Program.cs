        // Exercício Sequencia Fibonacci
        Console.WriteLine("--- Sequência Fibonacci ---");
        Console.Write("Digite um valor inteiro e positivo como limite: ");

        if (int.TryParse(Console.ReadLine(), out int limite) && limite >= 0)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine($"\nSequência Fibonacci até {limite}:");

            Console.Write(a);

            while (b <= limite)
            {

                Console.Write(", " + b);

                int proximo = a + b;

                a = b;
                b = proximo;
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("\nEntrada inválida. Por favor, execute o programa novamente e digite um número inteiro e positivo.");
        }
    
