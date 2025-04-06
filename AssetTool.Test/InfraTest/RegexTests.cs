using NUnit.Framework;
using System.Text.RegularExpressions;

namespace AssetTool.Test.InfraTest
{
    public class RegexTests : TestBase
    {
        [TestCase("float 'x'[1] {6B29FC40-CA47-1067-B31D-00DD010662DA}", "x", "1", "6B29FC40-CA47-1067-B31D-00DD010662DA")]
        [TestCase("float 'y' {6B29FC40-CA47-1067-B31D-00DD010662DA}", "y", "", "6B29FC40-CA47-1067-B31D-00DD010662DA")]
        [TestCase("float 'z'[1]", "z", "1", "")]
        [TestCase("float 'w'", "w", "", "")]
        [TestCase("float 'name with space'", "name with space", "", "")]
        public void Test_FFloatPropertyJson(string input, string name, string index, string guid)
        {
            var match = Regex.Match(input, new FFloatPropertyJson().Pattern);
            Assert.That(match.Success);
            Assert.That(match.Groups[2].Value, Is.EqualTo(name));
            Assert.That(match.Groups[3].Value, Is.EqualTo(index));
            Assert.That(match.Groups[4].Value, Is.EqualTo(guid));
        }

        [Theory]
        [TestCase("byte32 (EnumName) 'x'[1] {6B29FC40-CA47-1067-B31D-00DD010662DA}", "EnumName", "x", "1", "6B29FC40-CA47-1067-B31D-00DD010662DA")]
        [TestCase("byte32 'y'[1] {6B29FC40-CA47-1067-B31D-00DD010662DA}", "", "y", "1", "6B29FC40-CA47-1067-B31D-00DD010662DA")]
        [TestCase("byte32 'z'", "", "z", "", "")]
        [TestCase("byte32 'name with space'", "", "name with space", "", "")]
        [TestCase("byte32 (EnumName) 'name with space' {6B29FC40-CA47-1067-B31D-00DD010662DA}", "EnumName", "name with space", "", "6B29FC40-CA47-1067-B31D-00DD010662DA")]
        public void Test_FByte32PropertyJson(string input, string enumName, string name, string index, string guid)
        {
            var match = Regex.Match(input, new FByte32PropertyJson().Pattern);
            Assert.That(match.Success);
            Assert.That(match.Groups[1].Value, Is.EqualTo(enumName));
            Assert.That(match.Groups[2].Value, Is.EqualTo(name));
            Assert.That(match.Groups[3].Value, Is.EqualTo(index));
            Assert.That(match.Groups[4].Value, Is.EqualTo(guid));
        }
    }
}
