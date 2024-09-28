namespace AssetTool.Test.InfraTest
{
    public class SerializationTests : TestBase
    {
        [Fact]
        public void VectorMaterialInput_Should_Succeed()
        {
            var obj = new FVectorMaterialInput
            {
                UseConstant = new FBool(true),
                Constant = new FVector3f { X = 1, Y = 2, Z = 3 }
            };

            string json = obj.ToJson();

            Assert.NotNull(json);
        }
    }
}
