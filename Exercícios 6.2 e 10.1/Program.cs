using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios_6._2_e_10._1
{
    class Program
    {            //@author Marcella
        static void Main(string[] args)
        {
            int soma = 0; //Variável para somar a quantidade de ACERTOS

            Console.WriteLine("Quiz de conhecimentos gerais. Informe a alternativa correta e obtenha a maior pontuação!");
            Console.WriteLine("Responda inserindo o número da opção: 1, 2, 3 ou 4.");
            Console.WriteLine(); //Pula uma linha.

            int Tese; //Primeira pergunta
            Console.WriteLine("O atentado terrorista às Torres Gêmeas ocorreu em:");
            Console.WriteLine("1 - 1945");
            Console.WriteLine("2 - 1999");
            Console.WriteLine("3 - 2012");
            Console.WriteLine("4 - 2001");
            Tese = int.Parse(Console.ReadLine()); //Lê os dados informados.
            Console.WriteLine();

            switch (Tese) //Verifica o valor informado e caso o encontre entrega a resposta programada.
            {
                case 1:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Acertou!");
                    soma++; //Soma +1 caso o usuário tenha Acertado.
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Você escolheu uma opção inválida!"); //Essa opção será exibida caso o usuário digite qualquer coisa diferente de "1", "2", "3" ou "4".
                    Console.WriteLine();
                    break;
            }

            int Doutorado; //Segunda Pergunta
            Console.WriteLine("Um anime popular, que por muito tempo esteve ao lado de One Piece, tem como tradução literal de seu nome 'Alvejante'. Esse anime é:");
            Console.WriteLine("1 - Naruto");
            Console.WriteLine("2 - Bleach");
            Console.WriteLine("3 - Gintama");
            Console.WriteLine("4 - Fate");
            Doutorado = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (Doutorado)
            {
                case 1:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Acertou!");
                    soma++;
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Você escolheu uma opção inválida!");
                    Console.WriteLine();
                    break;
            }

            int TCC; //Terceira Pergunta
            Console.WriteLine("Weebtons são publicações online de Manwhas sul-coreanos que estão se tornando tão populares quanto os Mangás japoneses. Dentre os mais bem avaliados temos Tower of God e Solo Leveling, e ao seguir esse padrão de nomes, o próximo citado seria:");
            Console.WriteLine("1 - The Beginning After the End");
            Console.WriteLine("2 - DICE");
            Console.WriteLine("3 - Love Advice from the Great Duke of Hell");
            Console.WriteLine("4 - RPG");
            TCC = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (TCC)
            {
                case 1:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("Errou.");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Acertou!");
                    soma++;
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Opção inválida, mas todos esses são ótimos.");
                    Console.WriteLine();
                    break;
            }

            int Mestrado; //Quarta e Última Pergunta
            Console.WriteLine("Escolha a alternativa que mais se aprofunda no raciocínio suicida:");
            Console.WriteLine("1 - 'Hey, you. You are finally awake. . . You were trying to cross the border, right? '");
            Console.WriteLine("2 - 'Life is a deadly sexually transmitted disease'");
            Console.WriteLine("3 - 'I REJECT MY HUMANITY!'");
            Console.WriteLine("4 - 'I don't want it.'");
            Mestrado = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (Mestrado)
            {
                case 1:
                    Console.WriteLine("'Same as us, and that thief over there. We all failed on the 4th challenge.'");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("Acertou!");
                    soma++;
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("A bit closer to heaven, but it's wrong.");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("Olá Jon Snow! A resposta correta é um pouco mais específica.");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Inválido. Para a otimização de seu pessimismo recomenda-se Nietzsche.");
                    Console.WriteLine();
                    break;
            }


            Console.WriteLine("Seu total de pontos foi: " + soma);

            Console.ReadKey();
        }
    }
}
