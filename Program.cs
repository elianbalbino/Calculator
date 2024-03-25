using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Qual operação deseja executar?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 -  Multiplicação");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("------------------");
            Console.WriteLine("Digite a opção desejada");
#pragma warning disable CS8604 // Possible null reference argument.
            short resultadoMenu = short.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            switch (resultadoMenu)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }



        }

        static void Soma()
        {
            Console.WriteLine("Digite o primeiro valor: ");
#pragma warning disable CS8604 // Possible null reference argument.
            double primeiroValor = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor:");
#pragma warning disable CS8604 // Possible null reference argument.
            double segundoValor = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            double resultadoSoma = primeiroValor + segundoValor;
            Console.WriteLine("O resultado é " + resultadoSoma);
            //outra forma é a INTERPOLAÇÃO colocando o $ na frente-colado da string e acrescentando {} no resultado:
            // Console.WriteLine($"O resultado é: {resultado}");
            // //outra forma é a INTERPOLAÇÃO colocando o $ na frente-colado da string e acrescentando a fórmula dentro das {}:
            // Console.WriteLine($"O resultado é {primeiroValor + segundoValor}");

            Menu();
        }

        static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro valor:");
#pragma warning disable CS8604 // Possible null reference argument.
            double primeiroValor = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            Console.WriteLine("");


            Console.WriteLine("Digite o segundo valor:");
#pragma warning disable CS8604 // Possible null reference argument.
            double segundoValor = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            double resultadoSubtracao = primeiroValor - segundoValor;
            Console.WriteLine("O resultado da subtração é: " + resultadoSubtracao);

            Menu();

        }

        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro valor: ");
#pragma warning disable CS8604 // Possible null reference argument.
            double primeiroValor = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor:");
#pragma warning disable CS8604 // Possible null reference argument.
            double segundoValor = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            double resultadoDivisao = primeiroValor / segundoValor;
            Console.WriteLine("O resultado da divisão é: " + resultadoDivisao);

            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro valor:");
#pragma warning disable CS8604 // Possible null reference argument.
            double primeiroValor = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            Console.WriteLine("");

            Console.WriteLine("Digite o segundo valor:");
#pragma warning disable CS8604 // Possible null reference argument.
            double segundoValor = double.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Possible null reference argument.

            double resultadoMultiplicacao = primeiroValor * segundoValor;
            Console.WriteLine("O resultado da Multiplicação é: " + resultadoMultiplicacao);

            Menu();
        }
    }

}