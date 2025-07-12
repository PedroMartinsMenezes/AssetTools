using NUnit.Framework;
using System.Text.Json.Nodes;

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

            string json = obj.ToJson();

            var node = JsonObject.Parse(json);

            Assert.That(node["UseConstant"].GetValue<bool>(), Is.EqualTo(true));
            Assert.That(node["Constant"].GetValue<string>(), Is.EqualTo("1 2 3"));
        }
    }
}
