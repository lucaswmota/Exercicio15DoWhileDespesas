using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio15DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                string resp;
                double total = 0;

                do
                {
                    Console.Write("Descreva o gasto: ");
                    string gasto = Console.ReadLine();

                    Console.Write("Informe o valor gasto com " + gasto + ": R$ ");
                    double valorGasto = double.Parse(Console.ReadLine());

                    while (valorGasto <= 0)
                    {
                        Console.WriteLine("O Valor não pode ser menor do que o (Zero)");
                        Console.Write("Informe o valor gasto com " + gasto + ": R$ ");
                        valorGasto = double.Parse(Console.ReadLine());
                    }

                    total += valorGasto;

                    Console.WriteLine("Deseja adicionar mais um gasto?");
                    Console.WriteLine("(S) - sim" +
                        "\n(N) - Não");
                    resp = Console.ReadLine().ToUpper();

                    while(resp != "S" && resp != "N")
                    {
                        Console.WriteLine("Opção incorreta" +
                            "\nTente novamente.");
                        Console.WriteLine("Deseja adicionar mais um gasto?");
                        Console.WriteLine("(S) - sim" +
                            "\n(N) - Não");
                        resp = Console.ReadLine().ToUpper();
                    }

                    if (resp == "N")
                    {
                        Console.WriteLine("Valor Total dos gastos: " + total.ToString("C"));
                        Console.WriteLine("Encerrando...");
                        Console.WriteLine("Programa encerrado.");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }

                }
                while (resp == "S");

                Console.WriteLine("Valor Total dos gastos: " + total.ToString("C"));               

            }

            catch(System.FormatException)
            {
                Console.WriteLine("Digite apenas números");
            }
            finally
            {
                Console.WriteLine("Programa encerrado.");
                Console.ReadKey();
            }
        }
    }
}