using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    internal class Menu
    {
        public void menu()
        {

            Console.WriteLine();
            int opcao;
            do
            {

                Console.WriteLine("Selecione um:");
                Console.WriteLine("1 - Iniciar");
                Console.WriteLine("2 - Executar");
                Console.WriteLine("3 - Finalizar");
                Console.WriteLine();

                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Seja bem vindo!");
                        break;

                    case 2:
                        Console.WriteLine("Hello Word");
                        break;

                    case 3:
                    default:
                        break;
                }



               


            } while (opcao >= 3);
        }

    }
}

