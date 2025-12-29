using NUnit.Framework;
using System;
using System.IO;

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

            Assert.That(line, Is.EqualTo("text-base header=`Immutable` Key=`MyKey` Namespace=`MyNamespace` SourceString=`This is Text Base`"));
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

            Assert.That(line, Is.EqualTo("text-as-date header=`Immutable` SourceDateTime=`639027360000000000` DateStyle=`Full` TimeZone=`UTC` CultureName=`en-US`"));
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

            Assert.That(line, Is.EqualTo("text-as-time header=`Immutable` SourceDateTime=`639027360000000000` TimeStyle=`Full` TimeZone=`UTC` CultureName=`en-US`"));
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

            Assert.That(line, Is.EqualTo("text-as-date-time header=`Immutable` SourceDateTime=`639027360000000000` DateStyle=`Full` TimeStyle=`Full` TimeZone=`UTC` CultureName=`en-US`"));
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

            Assert.That(line, Is.EqualTo("text-string-table-entry header=`Immutable` TableId=`None` Key=`MyKey`"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_06_FTextHistory_TextGenerator_Should_Serialize_To_String()
        {
            AppConfig.DebugCheckMember = true;
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.TextGenerator;
            var textData = new FTextHistory_TextGenerator();
            text.TextData = textData;
            textData.GeneratorTypeID = new FName("MyType");
            textData.GeneratorContents = [1, 2, 3];

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            transferReader.GlobalNames.NameToIndex["MyType"] = 2;

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-generator header=`Immutable` GeneratorTypeID=`MyType` GeneratorContents=`1 2 3`"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_07_FTextHistory_NamedFormat_Should_Serialize_To_String()
        {
            AppConfig.DebugCheckMember = true;

            FText sourceFmt = new();
            sourceFmt.Flags = ETextFlag.Immutable;
            sourceFmt.HistoryType = ETextHistoryType.Base;
            var textDataBase = new FTextHistory_Base();
            sourceFmt.TextData = textDataBase;
            textDataBase.Namespace = new("Namespace1");
            textDataBase.Key = new("Key1");
            textDataBase.SourceString = new("SourceFmt1");

            FFormatArgumentValue arg1 = new();
            arg1.Type = EFormatArgumentType.Int;
            arg1.IntValue = 10;

            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.NamedFormat;
            var textData = new FTextHistory_NamedFormat();
            text.TextData = textData;
            textData.SourceFmt = sourceFmt;
            textData.Arguments = new() { { new FString("Key1"), arg1 } };

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-named-format header=`Immutable` SourceFmt(text-base header=`Immutable` Key=`Key1` Namespace=`Namespace1` SourceString=`SourceFmt1`) Keys(`Key1`) Values(`int 10`)"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }
    }
}
