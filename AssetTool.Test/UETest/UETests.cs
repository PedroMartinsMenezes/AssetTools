using NUnit.Framework;
using System.Threading.Tasks;

namespace AssetTool.Test.UETests
{
    public class UETests : TestBase
    {
        [Test]
        public async Task Test_01_UE56_Assets()
        {
            await Test_UE_Files("UE56_Files");
        }

        [Test]
        public async Task Test_01_UE56_Maps()
        {
            await Test_UE_Files("UE56_Map_Files");
        }

        [Test]
        public async Task Test_02_UE55_Assets()
        {
            await Test_UE_Files("UE55_Files");
        }

        [Test]
        public async Task Test_02_UE55_Maps()
        {
            await Test_UE_Files("UE55_Map_Files");
        }

        [Test]
        public async Task Test_03_UE54_Assets()
        {
            await Test_UE_Files("UE54_Files");
        }

        [Test]
        public async Task Test_03_UE54_Maps()
        {
            await Test_UE_Files("UE54_Map_Files");
        }

        [Test]
        public async Task Test_04_UE53_Assets()
        {
            await Test_UE_Files("UE53_Files", true);
        }

        [Test]
        public async Task Test_04_UE53_Maps()
        {
            await Test_UE_Files("UE53_Map_Files", true);
        }
    }
}