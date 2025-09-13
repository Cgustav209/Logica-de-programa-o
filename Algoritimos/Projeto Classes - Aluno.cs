using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    public class Aluno
    {
        public string Idade;
        public string Turma;
        public string Nome;

        public void MostrarDetalhes() 
        { 
        Console.WriteLine($"Nome: {Nome}");         
        Console.WriteLine($"Turma: {Turma}");         
        Console.WriteLine($"Idade: {Idade}");         
        
        }
        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e faço parte da turma {Turma}");

        }


    }
}
