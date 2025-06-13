using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;

namespace Projeto_calsses
{
    internal class Program
    {
        static void Main(string[] args)
        {


            LaçosRepetições Repiticao = new LaçosRepetições();
            Repiticao.Repeticao();

            Menu segundoExercicio = new Menu();
            segundoExercicio.menu();

            Imprimir imprimir = new Imprimir();
            imprimir.sequecia();

            Tabuada tabuadaEscolhida = new Tabuada();
            tabuadaEscolhida.tabuada();

            Jogo DeAzar = new Jogo();
            DeAzar.jogo();


            //ContaBancaria contaBancaria = new ContaBancaria();
            //{

            //    Console.WriteLine("Quanto você tem na conta:");
            //    double Saldo = Convert.ToDouble(Console.ReadLine());
            //    Console.Clear();

            //    Console.WriteLine("Deposite um valor");
            //    double Valor = Convert.ToDouble(Console.ReadLine());


            //    contaBancaria.Depositar(Saldo, Valor);
            //    contaBancaria.CosultarSaldo(Saldo);

            //}





            //Retangulo retangulo = new Retangulo();
            //{
            //    Console.WriteLine("Digite a base do retangulo");
            //    double Base = Convert.ToDouble(Console.ReadLine());
            //    Console.Clear();

            //    Console.WriteLine("Digite a altura do retangulo");
            //    double Altura = Convert.ToDouble(Console.ReadLine());
            //    Console.Clear();

            //    retangulo.CalcularArea(Base, Altura);

            //    retangulo.CalcularPerimetro(Base, Altura);


            //





            //Aluno primeiroAluno = new Aluno();
            //Aluno segundoAluno = new Aluno();

            //Console.WriteLine("Digite o nome do Aluno:");
            //primeiroAluno.Nome = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Qual sua Turma:");
            //primeiroAluno.Turma = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Qual sua idade:");
            //primeiroAluno.Idade = Console.ReadLine();
            //Console.Clear();



            //Console.WriteLine("Digite o nome do outro Aluno:");
            //segundoAluno.Nome = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Qual sua Turma:");
            //segundoAluno.Turma = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Qual sua idade:");
            //segundoAluno.Idade = Console.ReadLine();
            //Console.Clear();

            //primeiroAluno.MostrarDetalhes();
            //segundoAluno.MostrarDetalhes();
            //Console.Clear();




            //Livro livroItalo = new Livro();
            //Livro livroWagner = new Livro();

            //Console.WriteLine("Digite seu livro");
            //livroItalo.Titulo = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Qual o autor? ");
            //livroItalo.Autor = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Qual é o genero desse livro");
            //livroItalo.Genero = Console.ReadLine();
            //Console.Clear();





            //Console.WriteLine("Digite seu livro");
            //livroWagner.Titulo = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Qual o autor? ");
            //livroItalo.Autor = Console.ReadLine();
            //Console.Clear();

            //Console.WriteLine("Qual é o genero desse livro");
            //livroItalo.Genero = Console.ReadLine();
            //Console.Clear();

            //livroItalo.MostrarDetalhes();
            //livroWagner.MostrarDetalhes();



        }
    }
}