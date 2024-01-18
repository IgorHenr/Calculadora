using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("CALCULADORA VIA CONSOLE");
            Console.WriteLine("------------------------");
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1- Somar");
            Console.WriteLine("2- Subtrair");
            Console.WriteLine("3- Multiplicar");
            Console.WriteLine("4- Dividir");
            Console.WriteLine("5- Exponenciação");
            Console.WriteLine("0- Sair");
            Console.WriteLine("------------------------");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (choice == '0')
            {
                Environment.Exit(0);
            }

            if (choice < '1' || choice > '5')
            {
                Console.WriteLine("Opção inválida, tente novamente.");
                continue;
            }

            double num1, num2, resultado;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case '1':
                    resultado = num1 + num2;
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Resultado da operação: {resultado}");
                    Console.WriteLine("------------------------");
                    break;

                case '2':
                    resultado = num1 - num2;
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Resultado da operação: {resultado}");
                    Console.WriteLine("------------------------");
                    break;

                case '3':
                    resultado = num1 * num2;
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Resultado da operação: {resultado}");
                    Console.WriteLine("------------------------");
                    break;

                case '4':
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("------------------------");
                        Console.WriteLine($"Resultado da operação: {resultado}");
                        Console.WriteLine("------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Não é possível dividir por zero!");
                    }
                    break;

                case '5':
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine("------------------------");
                    Console.WriteLine($"Resultado da operação: {resultado}");
                    Console.WriteLine("------------------------");
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente!");
                    break;
            }

            Console.WriteLine("Aperte a tecla ENTER para realizar uma nova operação");
            Console.WriteLine("ou aperte 0 para sair");
        }
    }
}
