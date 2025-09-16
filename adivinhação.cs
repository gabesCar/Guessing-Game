using System;

class Program
{
    static void Main()
    {
        Random randNum = new Random(); // cria o gerador de números aleatórios
        int sorteio = randNum.Next(11); // número aleatório entre 0 e 10

        int usuario; // declara a variável que receberá o valor do usuário
        int tentativas = 5; // total de tentativas

        while (tentativas > 0)
        {
            Console.WriteLine("Digite um número...");
            string entrada = Console.ReadLine(); // lê a entrada como texto
            usuario = int.Parse(entrada); // converte para inteiro

            if (usuario == sorteio)
            {
                Console.WriteLine("Parabéns, você acertou!");
                break; // encerra o loop se acertar
            }
            else
            {
                Console.WriteLine("Você errou!");
            }

            tentativas--; // decrementa tentativas
        }

        Console.WriteLine("O número sorteado era " + sorteio);
    }
}


//testes de códigos utilizando while