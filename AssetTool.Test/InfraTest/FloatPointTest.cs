using NUnit.Framework;

namespace AssetTool.Test.InfraTest
{
    public class FloatPointTest : TestBase
    {
        [Test]
        public void Double_Serialization_Should_Fail_When_Default()
        {
            double original = 2.9802322387695313E-08;

            string text = original.ToString();

            double reconstructed = double.Parse(text);

            if (IsVs2026())
                Assert.That(reconstructed, Is.Not.EqualTo(original));
            else
                Assert.That(reconstructed, Is.EqualTo(original));
        }

        [Test]
        public void Double_Serialization_Should_Succeeded_When_G17()
        {
            double original = 2.9802322387695313E-08;

            string text = original.ToString("G17");

            double reconstructed = double.Parse(text);

            Assert.That(reconstructed, Is.EqualTo(original));
        }

        [Test]
        public void Double_ToString_Should_Be_()
        {
            double original = 1.2;
            string text = original.ToString();
            Assert.That(text, Is.EqualTo("1.2"));
        }
    }
}
