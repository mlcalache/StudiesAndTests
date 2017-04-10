using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSample.Business.UnitTest
{
    [TestClass]
    public class MyClassUnitTest
    {
        [TestMethod]
        public void TestAddition()
        {
            MyClass myClassInstance = new MyClass();
            double result;

            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Addition);

            Assert.AreEqual(result, 5);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            MyClass myClassInstance = new MyClass();
            double result;

            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Subtraction);
            
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            MyClass myClassInstance = new MyClass();
            double result;

            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Multiplication);

            Assert.AreEqual(result, 6);

            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Division);
        }

        [TestMethod]
        public void TestDivision()
        {
            MyClass myClassInstance = new MyClass();
            double result;
            
            result = myClassInstance.DoSomeMath(3, 2, MathOperationEnum.Division);

            Assert.AreEqual(result, 1.5);
        }
    }
}
