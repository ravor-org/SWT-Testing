using System.Buffers;
using Moq;
using SWT_TestedProject;

namespace SWT_Testing
{
    [TestFixture]
    public class FirstTest
    {
        private Calculator _testCalculator;

        [SetUp]
        public void Setup()
        {
            _testCalculator = new Calculator();
        }

        [Test]
        public void AdditionTest()
        {
            Assert.That(_testCalculator.Add(1, 1), Is.EqualTo(2));
        }

        [Test]
        public void SubtractionTest()
        {
            Assert.That(_testCalculator.Subtract(1, 1), Is.EqualTo(0));
        }

        [Test]
        public void MultiplicationTest()
        {
            Assert.That(_testCalculator.Multiply(12, 10), Is.EqualTo(120));
        }

        [Test]
        public void DivisionTest()
        {
            Assert.That(_testCalculator.Divide(4, 2), Is.EqualTo(2));
        }

        [Test]
        public void DivisionByZeroTest() {
            Assert.That(() => _testCalculator.Divide(4, 0), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void RemainingTest3By2()
        {
            Assert.That(() => _testCalculator.RemainingDiv(3, 2), Is.EqualTo(1));
        }
        
        [Test]
        public void RemainingTest2By2()
        {
            Assert.That(() => _testCalculator.RemainingDiv(2, 2), Is.EqualTo(0));
        }

        [Test]
        public void RemainingTest2By0()
        {
            Assert.That(() => _testCalculator.RemainingDiv(4, 0), Throws.TypeOf<DivideByZeroException>());
        }
        
        // Zuerst der Test dann der Rest!
        [Test]
        public void CheckCharToEur()
        {
            Assert.That(() => _testCalculator.AddEurToCalculation(_testCalculator.Add, 1, 1), Is.EqualTo("2€"));
        }

        [Test]
        public void MultiplyDoubleTest()
        {
            Assert.That(_testCalculator.MultiplyDouble(1.5, 3), Is.EqualTo(4.5));
        } 

        [Test]
        public void MockAddTest()
        {
            // Create Mocking instance of our calculator, which will - on purpose - fail on 1+1
            Mock<ICalculator> fakedCalc = new Mock<ICalculator>();
            // Setup mock to return 3 on 1+1
            fakedCalc.Setup(x => x.Add(1,1)).Returns(3);
            // Assert that the mock will work, instead of real function
            Assert.That(() => fakedCalc.Object.Add(1, 1), Is.EqualTo(3));
        }

        [Test]
        public void PartialCoverageTest()
        {
            Assert.That(_testCalculator.PartialCodeCoverage(11), Is.True);
        }
    }
}