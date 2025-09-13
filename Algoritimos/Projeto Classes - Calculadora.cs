using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    public class Calculadora
    {

        public void Somar(int primeiroNumero, int segundoNumero){



            int soma = primeiroNumero + segundoNumero;

            Console.WriteLine($"O resultado da conta é : {soma}");
        }

        public int Multiplicar() {

            Console.WriteLine("Digite o primeiro numero: ");
            int primeiroNumero = Convert.ToInt32( Console.ReadLine() );
            Console.Clear();

            Console.WriteLine("Digite o segundo numero: ");
            int segundoNumero = Convert.ToInt32( Console.ReadLine() );
            Console.Clear();

            int resultado = primeiroNumero * segundoNumero;
           

            return resultado;   
            
        } 

    }
}
