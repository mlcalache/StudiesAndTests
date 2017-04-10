using System;
using UnitTestSample.Business;

namespace UnitTestSample.ConsoleClient
{
    class Program
    {
        /// <summary>
        /// Método principal que será executado pelo projeto.
        /// </summary>
        /// <param name="args">Parâmetros opcionais para o console</param>
        static void Main(string[] args)
        {
            MyClass myClassInstance = new MyClass();
            double result;

            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Addition);
            Console.WriteLine($"Resultado: {result}");

            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Subtraction);
            Console.WriteLine($"Resultado: {result}");

            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Multiplication);
            Console.WriteLine($"Resultado: {result}");

            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Division);
            Console.WriteLine($"Resultado: {result}");

            Console.WriteLine("Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
