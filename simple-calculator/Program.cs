using System;
using System.Text;
using CalculatorEngine;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               
                Console.WriteLine("Welcome to Simple Calculator\nEnter  your first number then press Enter:");
                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter  your Second number then press Enter:");
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                Console.WriteLine("Enter your operator of choice, choices available are +, -, /, *, %. You can either enter the symbol of the operator or simply say the name" +
                    " of the operator such as \"add\" or \"subtract\" :");
                string operation = Console.ReadLine();

                double result = CalculatorEngine.CalculatorEngine.Calculate(operation, firstNumber, secondNumber);

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("The result of ");
                stringBuilder.Append(firstNumber);
                stringBuilder.Append(" ");
                stringBuilder.Append(operation);
                stringBuilder.Append(" ");
                stringBuilder.Append(secondNumber);
                stringBuilder.Append(" is ");
                stringBuilder.AppendFormat("{0:F2}", result);
                Console.WriteLine(stringBuilder.ToString());

            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }

        }
    }
}