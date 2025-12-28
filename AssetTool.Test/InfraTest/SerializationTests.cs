using NUnit.Framework;
using System.IO;
using System.Text.Json.Nodes;

namespace AssetTool.Test.InfraTest
{
    //[Ignore("Irrelevant")]
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

        [Test]
        public void FText_Should_Serialize_To_String()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.Base;
            var textData = new FTextHistory_Base();
            text.TextData = textData;
            textData.Namespace = new("MyNamespace");
            textData.Key = new("MyKey");
            textData.SourceString = new("This is Text Base");

            using FileStream inputStream = new FileStream("C:\\UE\\Lyra\\Content\\Characters\\Heroes\\Mannequin\\Animations\\LinkedLayers\\ABP_ItemAnimLayersBase.uasset", FileMode.Open, FileAccess.Read);
            using BinaryReader reader = new BinaryReader(inputStream);
            using Transfer transferReader = new TransferReader(reader);

            AssetPackage asset = new AssetPackage();

            asset.MoveHeader(transferReader);

            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            long[] offsets = [0, transferWriter.Position];

            AppConfig.DebugCheckMember = true;
            bool success = text.AutoCheck(transferReader, "", transferWriter.Stream, offsets);

            Assert.That(success);
        }
    }
}
