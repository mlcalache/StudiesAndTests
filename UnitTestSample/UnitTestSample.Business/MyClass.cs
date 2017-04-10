using System;

namespace UnitTestSample.Business
{
    public class MyClass
    {
        public double DoSomeMath(double operator1, double operator2, MathOperationEnum mathOperation)
        {
            double result;

            switch (mathOperation)
            {
                case MathOperationEnum.Addition:
                    result = operator1 + operator2;
                    break;
                case MathOperationEnum.Subtraction:
                    result = operator1 - operator2;
                    break;
                case MathOperationEnum.Multiplication:
                    result = operator1 * operator2;
                    break;
                case MathOperationEnum.Division:
                    result = operator1 / operator2;
                    break;
                default:
                    throw new Exception(UnitTestSampleBusinessResource.NenhumaOperacaoMatematicaFoiEscolhida);
            }

            return result;
        }
    }
}
