using System;

namespace ConsoleApp1
{
    class Program
    {
        private static string operation;
        private static string firstNumberS;
        private static string secondNumberS;
        private static string otherOperation;
        private static double firstNumber;
        private static double secondNumber;
        private static double result;

        static void Main(string[] args)
        {
            groupName();
            initCalculadora();
        }

        private static void groupName()
        {
            Console.WriteLine("Integrantes do grupo:");
            Console.WriteLine("Alana Gabrieli Cardoso (2022100399);");
            Console.WriteLine("Carlos Eduardo Krueger da Silva (2022101785);");
            Console.WriteLine("Letícia da Silva Campos (2022101773);\n\n");
        }

        private static void initCalculadora()
        {
            Console.WriteLine("Calculadora!\n");
            collectNumbers();

        }

        private static void collectNumbers()
        {
            Console.Write("Digite um valor:");
            firstNumberS = Console.ReadLine();

            Console.Write("Digite outro valor:");
            secondNumberS = Console.ReadLine();

            if(verifyNumbers())
            {
                firstNumber = validateNumbers(firstNumberS);
                secondNumber = validateNumbers(secondNumberS);

                selectOperation();

            } else
            {
                collectNumbers();
            }
        }

        private static bool verifyNumbers()
        {
            if (string.IsNullOrEmpty(firstNumberS))
            {
                return false;
            }

            if (string.IsNullOrEmpty(secondNumberS))
            {
                return false;
            }

            return true;
        }

        private static double validateNumbers(String num)
        {
            double validNumber;

            if (double.TryParse(num, out validNumber) == false)
            {
                Console.WriteLine("Insira um número válido para calcular: ");
                return validateNumbers(Console.ReadLine());
            }

            return validNumber;
        }

        private static void selectOperation()
        {
            Console.WriteLine("TABELA DE OPERAÇÕES:\n+ = Adição; - = Subtração; * = multiplicação; / = Divisão");
            Console.WriteLine("Qual operação você quer realizar?");
            operation = Console.ReadLine();

            verifyOperation(operation);
        }

        private static void verifyOperation(string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Resultado: {calculateSum()}");
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {calculateSubtraction()}");
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {calculateMultiplication()}");
                    break;
                case "/":
                    Console.WriteLine($"Resultado: {calculateDivision()}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida:");
                    operation = Console.ReadLine();

                    verifyOperation(operation);

                    break;
            }

            anotherOperation();
        }

        private static double calculateSum()
        {
            result = firstNumber + secondNumber;
            return result;
        }

        private static double calculateSubtraction()
        {
            result = firstNumber - secondNumber;
            return result;
        }

        private static double calculateMultiplication()
        {
            result = firstNumber * secondNumber;
            return result;
        }

        private static double calculateDivision()
        {
            result = firstNumber / secondNumber;
            return result;
        }

        private static void anotherOperation()
        {
            Console.WriteLine("Deseja realizar outra operação?");
            otherOperation = Console.ReadLine();

            verifyOtherOperation(otherOperation);
        }

        private static void verifyOtherOperation(string otherOperation)
        {
            if (isOtherOperation(otherOperation))
            {
                collectNumbers();
            }
            else
            {
                Console.WriteLine("Tchau Tchau!");
                return;
            }
        }

        private static bool isOtherOperation(string otherOperation)
        {
            if (otherOperation == "Sim" || otherOperation == "sim" || otherOperation == "yes")
            {
                return true;  
            }

            return false;
        }
    }
}
