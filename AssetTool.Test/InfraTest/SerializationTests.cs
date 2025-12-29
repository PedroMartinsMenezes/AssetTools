using NUnit.Framework;
using System;
using System.IO;
using System.Text.Json.Nodes;

namespace AssetTool.Test.InfraTest
{
    //[Ignore("Irrelevant")]
    public class SerializationTests : TestBase
    {
        [Test]
        public void Test_01_FTextHistory_Base_Should_Serialize_To_String()
        {
            AppConfig.DebugCheckMember = true;
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.Base;
            var textData = new FTextHistory_Base();
            text.TextData = textData;
            textData.Namespace = new("MyNamespace");
            textData.Key = new("MyKey");
            textData.SourceString = new("This is Text Base");

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-base Flags(`Immutable`)  | Key(`MyKey`) Namespace(`MyNamespace`) SourceString(`This is Text Base`)"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_02_FTextHistory_AsDate_Should_Serialize_To_String()
        {
            AppConfig.DebugCheckMember = true;
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsDate;
            var textData = new FTextHistory_AsDate();
            text.TextData = textData;
            textData.SourceDateTime = new FDateTime { Ticks = new DateTime(2025, 12, 31).Ticks };
            textData.DateStyle = EDateTimeStyle.Full;
            textData.TimeZone = new("UTC");
            textData.CultureName = new("en-US");

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-as-date Flags(`Immutable`)  | SourceDateTime(`639027360000000000`) DateStyle(`Full`) TimeZone(`UTC`) CultureName(`en-US`)"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_03_FTextHistory_AsTime_Should_Serialize_To_String()
        {
            AppConfig.DebugCheckMember = true;
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsTime;
            var textData = new FTextHistory_AsTime();
            text.TextData = textData;
            textData.SourceDateTime = new FDateTime { Ticks = new DateTime(2025, 12, 31).Ticks };
            textData.TimeStyle = EDateTimeStyle.Full;
            textData.TimeZone = new("UTC");
            textData.CultureName = new("en-US");

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-as-time Flags(`Immutable`)  | SourceDateTime(`639027360000000000`) TimeStyle(`Full`) TimeZone(`UTC`) CultureName(`en-US`)"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_04_FTextHistory_AsDateTime_Should_Serialize_To_String()
        {
            AppConfig.DebugCheckMember = true;
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsDateTime;
            var textData = new FTextHistory_AsDateTime();
            text.TextData = textData;
            textData.SourceDateTime = new FDateTime { Ticks = new DateTime(2025, 12, 31).Ticks };
            textData.DateStyle = EDateTimeStyle.Full;
            textData.TimeStyle = EDateTimeStyle.Full;
            textData.TimeZone = new("UTC");
            textData.CultureName = new("en-US");

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-as-date-time Flags(`Immutable`)  | SourceDateTime(`639027360000000000`) DateStyle(`Full`) TimeStyle(`Full`) TimeZone(`UTC`) CultureName(`en-US`)"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_05_FTextHistory_StringTableEntry_Should_Serialize_To_String()
        {
            AppConfig.DebugCheckMember = true;
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.StringTableEntry;
            var textData = new FTextHistory_StringTableEntry();
            text.TextData = textData;
            textData.TableId = new FName("None");
            textData.Key = new FString("MyKey");

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-string-table-entry Flags(`Immutable`)  | TableId(`None`) Key(`MyKey`)"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_99_VectorMaterialInput_Should_Succeed()
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
