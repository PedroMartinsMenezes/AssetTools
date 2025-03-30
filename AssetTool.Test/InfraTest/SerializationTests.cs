using NUnit.Framework;

namespace AssetTool.Test.InfraTest
{
    public class SerializationTests : TestBase
    {
        [Test]
        public void VectorMaterialInput_Should_Succeed()
        {
            var obj = new FVectorMaterialInput
            {
                UseConstant = new FBool(true),
                Constant = new FVector3f { X = 1, Y = 2, Z = 3 }
            };

            string json = obj.ToJson(new TransferReader(null));

            Assert.That(json is null);
        }
    }
}
