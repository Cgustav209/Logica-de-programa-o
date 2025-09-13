using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    public class ContaBancaria
    {
       public int NumeroConta { get; set;}
        public string NomeTitular { get; set; }

        public double Saldo = 100;

        public void ConsultarSaldo() {
            Console.WriteLine($"Olá {NomeTitular}, seu saldo é de {Saldo}");
            
        }
        public void Depositar() {
            Console.WriteLine("Digite o valor do deposito: ");
            double ValorDeposito = Convert.ToDouble(Console.ReadLine());

        }


    }
}
