using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");

            bool continuar = true;

            while (continuar)
            {
                ExibirMenu();

                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        RealizarSoma();
                        break;
                    case "2":
                        RealizarSubtracao();
                        break;
                    case "3":
                        RealizarMultiplicacao();
                        break;
                    case "4":
                        RealizarDivisao();
                        break;
                    case "5":
                        continuar = false;
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        static void ExibirMenu()
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
        }

        static void RealizarSoma()
        {
            Console.WriteLine("\n=== SOMA ===");
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 + num2;
            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
        }

        static void RealizarSubtracao()
        {
            Console.WriteLine("\n=== SUBTRAÇÃO ===");
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 - num2;
            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
        }
        static void RealizarMultiplicacao()
        {
            Console.WriteLine("\n=== MULTIPLICAÇÃO ===");
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = num1 * num2;
            Console.WriteLine($"Resultado: {num1} × {num2} = {resultado}");
        }
        
                static void RealizarDivisao()
        {
            Console.WriteLine("\n=== DIVISÃO ===");
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            
            if (num2 == 0)
            {
                Console.WriteLine("ERRO: Não é possível dividir por zero!");
            }
            else
            {
                double resultado = num1 / num2;
                Console.WriteLine($"Resultado: {num1} ÷ {num2} = {resultado}");
            }
        }
        
    }
}