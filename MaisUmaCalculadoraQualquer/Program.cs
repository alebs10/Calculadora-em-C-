using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaisUmaCalculadoraQualquer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("BEM VINDO A CALCULADORA");
            Console.WriteLine("***********************");
            Thread.Sleep(3200);
            Console.Clear();

            Inicio:
            Console.Clear();
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Clear();

            double resultado = 0;

            Opcao:
            Console.WriteLine("Digite um sinal das seguintes operações: ");
            Console.WriteLine("\t+ -> Adição");
            Console.WriteLine("\t- -> Subtração");
            Console.WriteLine("\t* -> Multiplicação");
            Console.WriteLine("\t/ -> Divisão\n");

            char escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + resultado);
                    break;
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine(num1 + " * " + num2 + " = " + resultado);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não será possivel dividir por 0");   
                    }
                    else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + resultado);                       
                    }
                    break;
                default:
                    Console.WriteLine("Por favor escolha entre as demais opções novamente...");
                    goto Opcao;
            }

            Console.WriteLine("Deseja continuar calculando ? (sim)/(não)");
            string op = Console.ReadLine();

            if (op == "sim" || op == "Sim" || op == "SIM")
            {
                goto Inicio;
            }

            Console.WriteLine("Pressione qualquer tecla para encerrar...");
            Console.Read();
        }
    }
}
