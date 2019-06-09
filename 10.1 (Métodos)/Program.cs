using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1__Métodos_
{
    class Program
    {            //@author Marcella
        static void Main(string[] args)
        {
            string nome; //a.k.a. pepperoni
            float saldo; //a.k.a. salmão

            void CadastrarUsuario()
            {
                Console.WriteLine("Informe o nome do usuário:");
                nome = Console.ReadLine();

                Console.WriteLine("Informe o saldo do usuário:");
                saldo = float.Parse(Console.ReadLine());
                Console.WriteLine(); //Pula uma linha.
            }

            void ConsultarConta()
            {
                Console.WriteLine("A conta de " + nome + " contém " + saldo + " de saldo.");
                Console.WriteLine(); //Pula uma linha.
            }

            void ApagarConta()
            {
                saldo = 0; //Estabelece o valor "0" para a variável "saldo".
                nome = string.Empty; //Esvazia a variável "nome".
                Console.WriteLine(); //Pula uma linha.
            }

            CadastrarUsuario();
            ConsultarConta();
            ApagarConta();
            ConsultarConta();

            Console.ReadKey();
        }
    }
}
