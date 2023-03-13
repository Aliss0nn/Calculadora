using System.IO.Pipes;
using System.Security.AccessControl;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("         Calculadora pouco Confiável\n        ");

                Console.WriteLine("Qual operação deseja:");
              
                Console.WriteLine();
                Console.WriteLine("1 para adição");
               
                Console.WriteLine("2 para Subtração");
               
                Console.WriteLine("3 para Multiplicação");
               
                Console.WriteLine("4 para Divisão");
                Console.WriteLine();
               
                Console.WriteLine("Digite S para sair");
                String operaçao = Console.ReadLine();

                if (operaçao == "S" || operaçao == "s")
                {

                    break;
                
                }
                if (operaçao != "1" && operaçao != "2" && operaçao != "3" && operaçao != "4" && operaçao != "S" && operaçao != "s")
                {
                    Console.WriteLine(" Comando Inexistente");
                    Console.ReadLine();
                    continue;
                }

                Console.Write("Digite o primeiro número: ");

                

                decimal primeironumero = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Digite o segundo número: ");

                

                decimal segundonumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                bool adição = operaçao == "1";
                bool subtração = operaçao == "2";
                bool Multiplicação = operaçao == "3";
                bool Divisão = operaçao == "4";

                if (adição)
                {
                    resultado = primeironumero + segundonumero;
                }

                else if (subtração)
                {
                    resultado = primeironumero - segundonumero;
                }

                else if (Multiplicação)
                {
                    resultado = primeironumero * segundonumero;
                }

                else if (Divisão)

                    if (segundonumero != 0)
                    {
                        resultado = primeironumero / segundonumero;
                    }

                    else
                    {
                        Console.WriteLine("Dividir por zero, não da meu consagrado, vai denovo...");

                        Console.ReadLine();

                        Console.WriteLine("Digite o segundo número");
                    }
                                                                                      
               Decimal reultado2casa = Math.Round(resultado, 2);

                Console.WriteLine();

                Console.WriteLine("O Resultado da operação é: " + reultado2casa);

                Console.ReadLine();
               

            } while (true);  
        }

    }
}

