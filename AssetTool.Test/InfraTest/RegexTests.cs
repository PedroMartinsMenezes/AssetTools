using System.Text.RegularExpressions;

namespace AssetTool.Test.InfraTest
{
    public class RegexTests : TestBase
    {
        [Theory]
        [InlineData("float 'x'[1] (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, true, true)]
        [InlineData("float 'y' (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, false, true)]
        [InlineData("float 'z'[1]", true, true, false)]
        [InlineData("float 'w'", true, false, false)]
        [InlineData("float 'name with space'", true, false, false)]
        public void DetectFloat(string input, bool hasName, bool hasIndex, bool hasGuid)
        {
            var match = Regex.Match(input, FFloatPropertyJson.Pattern);
            Assert.True(match.Success);
            Assert.Equal(hasName, match.Groups[1].Value.Length > 0);
            Assert.Equal(hasIndex, match.Groups[2].Value.Length > 0);
            Assert.Equal(hasGuid, match.Groups[3].Value.Length > 0);
        }

        [Theory]
        [InlineData("byte32 (EnumName) 'x'[1] (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, true, true, true)]
        [InlineData("byte32 'y'[1] (6B29FC40-CA47-1067-B31D-00DD010662DA)", false, true, true, true)]
        [InlineData("byte32 'z'", false, true, false, false)]
        [InlineData("byte32 'name with space'", false, true, false, false)]
        [InlineData("byte32 (EnumName) 'name with space' (6B29FC40-CA47-1067-B31D-00DD010662DA)", true, true, false, true)]
        public void DetectByte32(string input, bool hasEnum, bool hasName, bool hasIndex, bool hasGuid)
        {
            var match = Regex.Match(input, FByte32PropertyJson.Pattern);
            Assert.True(match.Success);
            Assert.Equal(hasEnum, match.Groups[1].Value.Length > 0);
            Assert.Equal(hasName, match.Groups[2].Value.Length > 0);
            Assert.Equal(hasIndex, match.Groups[3].Value.Length > 0);
            Assert.Equal(hasGuid, match.Groups[4].Value.Length > 0);
        }
    }
}
