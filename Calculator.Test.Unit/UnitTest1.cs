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
            Assert.That(uut.Subtract(-4, 4), Is.EqualTo(-8));
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
            Assert.That(uut.Power(-4, 4), Is.EqualTo(256));
            Assert.That(uut.Power(4, -4), Is.EqualTo(0.00390625));
            Assert.That(uut.Power(-4, -4), Is.EqualTo(0.00390625));
        }
        [Test]
        public void DivideTest()
        {
            Assert.That(uut.Divide(4, 4), Is.EqualTo(1));
            Assert.That(uut.Divide(-4, 4), Is.EqualTo(-1));
            Assert.That(uut.Divide(4, -4), Is.EqualTo(-1));
            Assert.That(uut.Divide(-4, -4), Is.EqualTo(1));
            Assert.That(uut.Divide(4, 0), Is.EqualTo(double.NaN));
        }
        [Test]
        public void AccumulatorTest()
        {
            Assert.That(0, Is.EqualTo(uut.Accumulator));
            Assert.That(uut.Add(2, 4), Is.EqualTo(uut.Accumulator));
            Assert.That(uut.Subtract(2, 4), Is.EqualTo(uut.Accumulator));
            Assert.That(uut.Multiply(2, 4), Is.EqualTo(uut.Accumulator));
            Assert.That(uut.Divide(2, 4), Is.EqualTo(uut.Accumulator));
            Assert.That(uut.Power(2, 4), Is.EqualTo(uut.Accumulator));
        }
    }
}