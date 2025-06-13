using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    internal class LaçosRepetições
    {
        public void Repeticao()
        {
            int Numero;
            int Numero2;

            Console.WriteLine("Digite um numero para começar: ");
            Numero= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite até quando é pra repetir: ");
            Numero2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            do
            {
                Console.WriteLine(Numero);
                Numero = Numero + 1;


            } while (Numero < Numero2);
            {
                Console.WriteLine(Numero);
            }
            

        }
    
    }
}
