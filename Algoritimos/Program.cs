namespace Membros_estaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            int opcao;
            do
            {

                Console.WriteLine("Selecione qual operação você quer fazer:");
                Console.WriteLine("1 - multiplicação");
                Console.WriteLine("2 - divisão");
                Console.WriteLine("3 - adição");
                Console.WriteLine("4 - Subtração");
                Console.WriteLine();

                opcao = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o primeiro numero: ");
                        double Valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        double Valor2 = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine($"Resultado:{MatematicaUtil.Multiplicar(Valor1, Valor2)}");
                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Digite o primeiro numero: ");
                            Valor1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Digite o segundo numero: ");
                            Valor2 = Convert.ToDouble(Console.ReadLine());

                        } while (Valor2 == 0);


                        Console.WriteLine($"Resultado:{MatematicaUtil.Dividir(Valor1, Valor2)}");
                        break;

                    case 3:
                        Console.WriteLine("Digite o primeiro numero: ");
                        Valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        Valor2 = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine($"Resultado:{MatematicaUtil.Somar(Valor1, Valor2)}");

                        break;

                    case 4:
                        Console.WriteLine("Digite o primeiro numero: ");
                        Valor1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero: ");
                        Valor2 = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine($"Resultado:{MatematicaUtil.Subtrair(Valor1, Valor2)}");

                        break;

                }

            } while (opcao >= 5);
        }
    }
}


