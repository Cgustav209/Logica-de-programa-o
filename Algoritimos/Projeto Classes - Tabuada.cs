using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    internal class Tabuada
    {
        public void tabuada()
        {
            int numero;
            int Resultado;
            Console.WriteLine("Digite qual tabuada você quer sabe: ");
            numero= Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            for (int i = 1; i <= 10; i++) {
                Resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {Resultado}");

            }
        }
    }
}
