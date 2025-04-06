using NUnit.Framework;
using System.Text.RegularExpressions;

namespace AssetTool.Test.InfraTest
{
    public class RegexTests : TestBase
    {
        [TestCase("float 'x'[1] (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, true, true)]
        [TestCase("float 'y' (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, false, true)]
        [TestCase("float 'z'[1]", true, true, false)]
        [TestCase("float 'w'", true, false, false)]
        [TestCase("float 'name with space'", true, false, false)]
        public void DetectFloat(string input, bool hasName, bool hasIndex, bool hasGuid)
        {
            var match = Regex.Match(input, FFloatPropertyJson.Pattern);
            Assert.That(match.Success);
            Assert.That(hasName, Is.EqualTo(match.Groups[1].Value.Length > 0));
            Assert.That(hasIndex, Is.EqualTo(match.Groups[2].Value.Length > 0));
            Assert.That(hasGuid, Is.EqualTo(match.Groups[3].Value.Length > 0));
        }

        [Theory]
        [TestCase("byte32 (EnumName) 'x'[1] (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, true, true, true)]
        [TestCase("byte32 'y'[1] (6B29FC40-CA47-1067-B31D-00DD010662DA)", false, true, true, true)]
        [TestCase("byte32 'z'", false, true, false, false)]
        [TestCase("byte32 'name with space'", false, true, false, false)]
        [TestCase("byte32 (EnumName) 'name with space' (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, true, false, true)]
        public void DetectByte32(string input, bool hasEnum, bool hasName, bool hasIndex, bool hasGuid)
        {
            var match = Regex.Match(input, (new FByte32PropertyJson()).Pattern);
            Assert.That(match.Success);
            Assert.That(hasEnum, Is.EqualTo(match.Groups[1].Value.Length > 0));
            Assert.That(hasName, Is.EqualTo(match.Groups[2].Value.Length > 0));
            Assert.That(hasIndex, Is.EqualTo(match.Groups[3].Value.Length > 0));
            Assert.That(hasGuid, Is.EqualTo(match.Groups[4].Value.Length > 0));
        }
    }
}
