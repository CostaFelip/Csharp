using System;

namespace CalculadoraBasica
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
                        Console.WriteLine("Soma selecionada");
                        break;
                    case "2":
                        Console.WriteLine("Subtração selecionada");
                        break;
                    case "3":
                        Console.WriteLine("Multiplicação selecionada");
                        break;
                    case "4":
                        Console.WriteLine("Divisão selecionada");
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
    }
}