using exercise0;

namespace Calculator.Test.Unit
{
    public class CalculatorUnitTests
    {
        private exercise0.Calculator uut;

        [SetUp]
        public void Setup()
        {
            uut = new exercise0.Calculator();
        }

        [Test]
        public void AddTest()
        {
            Assert.That(uut.Add(6, 4), Is.EqualTo(10));
            Assert.That(uut.Add(-6, 4), Is.EqualTo(-2));
            Assert.That(uut.Add(-6, -4), Is.EqualTo(-10));
        }
        [Test]
        public void SubtractTest()
        {
            Assert.That(uut.Subtract(4, 4), Is.EqualTo(0));
            Assert.That(uut.Subtract(-4, 4), Is.EqualTo(-4));
            Assert.That(uut.Subtract(4, -4), Is.EqualTo(8));
            Assert.That(uut.Subtract(-4, -4), Is.EqualTo(0));
        }
        [Test]
        public void MultiplyTest()
        {
            Assert.That(uut.Multiply(4, 4), Is.EqualTo(16));
            Assert.That(uut.Multiply(-4, 4), Is.EqualTo(-16));
            Assert.That(uut.Multiply(-4, -4), Is.EqualTo(16));
        }
        [Test]
        public void PowerTest()
        {
            Assert.That(uut.Power(4, 4), Is.EqualTo(256));
            Assert.That(uut.Power(-4, 4), Is.EqualTo(-256));
            Assert.That(uut.Power(4, -4), Is.EqualTo(0.00390625));
            Assert.That(uut.Power(-4, -4), Is.EqualTo(-0.00390625));
        }
    }
}