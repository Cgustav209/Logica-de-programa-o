using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    internal class Retangulo
    {

        public void CalcularArea(double Base, double Altura)
        {

            double Area = Altura * Base;

            Console.WriteLine($"A aréa do retangulo é: {Area}");
        }
        public void CalcularPerimetro(double Base, double Altura)
        {
            double Perimetro = (Altura * 2) + (Base * 2);

            Console.WriteLine($"A Perimetro do retangulo é: {Perimetro}");


        }
        //Console.WriteLine($"Digite a altura: ");
        //int Altura = Convert.ToInt32(Console.ReadLine());
        //Console.Clear();

        //Console.WriteLine($"Digite a Base: ");
        //int Base = Convert.ToInt32(Console.ReadLine());
        //Console.Clear();

        //int Perimetro = (Altura * 2) + (Base * 2);

        //return Perimetro;

    }
}
