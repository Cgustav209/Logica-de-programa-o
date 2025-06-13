using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_calsses
{
    public class Livro
    {
        public string Titulo;
        public string Autor;
        public string Genero;





        public void MostrarDetalhes()
        {

            Console.WriteLine($"Titulo: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Genero: {Genero}");
        }

        public void ApresentarLivro()
        {
            Console.WriteLine($"Esse é o {Titulo} ");


        }
    }

  }
 


    