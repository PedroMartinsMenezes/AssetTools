using AssetTool.Generator;
using AssetTool.Generator.CodeGen;
using NUnit.Framework;

namespace AssetTool.Test.Blueprint
{
    public class BlueprintTest
    {
        [Test]
        public void StackOBot_Blueprint_Test()
        {
            string path = "C:\\UE\\StackOBot\\Content\\StackOBot\\Blueprints\\GameElements\\BP_Door.uasset";

            BlueprintTranslator translator = new();

            BlueprintCode blueprintCode = translator.GenerateCpp(path);

            Assert.IsNotNull(blueprintCode);
        }
    }
}
