using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    internal class Jogo
    {
        public void jogo() 
        {
            int numero;
            Random randon = new Random();
            int NumeroSecreto = randon.Next(1,5);
            Console.WriteLine("Vamos começar");
            do
            {
              
                Console.WriteLine("Digite um numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (numero != NumeroSecreto);

            Console.WriteLine("Parabens!");
        }
    }
}
