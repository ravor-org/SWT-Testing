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
}
}