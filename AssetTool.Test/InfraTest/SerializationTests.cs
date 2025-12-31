using NUnit.Framework;
using System;
using System.IO;

namespace AssetTool.Test.InfraTest
{
    //[Ignore("Irrelevant")]
    [SetCulture("")]
    [SetUICulture("")]
    public class SerializationTests : TestBase
    {
        [Test]
        public void Test_01_FTextHistory_Base()
        {
            AppConfig.DebugCheckMember = true;
            FText text = GetTextBase("N0", "K0", "S0");

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_02_FTextHistory_AsDate()
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
        public void Test_03_FTextHistory_AsTime()
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
        public void Test_04_FTextHistory_AsDateTime()
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
        public void Test_05_FTextHistory_StringTableEntry()
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
        public void Test_06_FTextHistory_TextGenerator()
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
        public void Test_07_FTextHistory_NamedFormat_A()
        {
            AppConfig.DebugCheckMember = true;
            FText sourceFmt = GetTextBase("N0", "K0", "S0");

            FFormatArgumentValue arg1 = new() { Type = EFormatArgumentType.Int, IntValue = -5 };
            FFormatArgumentValue arg2 = new() { Type = EFormatArgumentType.UInt, UIntValue = 10 };
            FFormatArgumentValue arg3 = new() { Type = EFormatArgumentType.Float, FloatValue = 0.5f };
            FFormatArgumentValue arg4 = new() { Type = EFormatArgumentType.Double, DoubleValue = 1.5f };
            FFormatArgumentValue arg5 = new() { Type = EFormatArgumentType.Gender, UIntValue = 100 };

            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.NamedFormat;
            var textData = new FTextHistory_NamedFormat();
            text.TextData = textData;
            textData.SourceFmt = sourceFmt;
            textData.Arguments = new() { { new FString("Key1"), arg1 }, { new FString("Key2"), arg2 }, { new FString("Key3"), arg3 }, { new FString("Key4"), arg4 }, { new FString("Key5"), arg5 } };

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-named-format header=`Immutable` SourceFmt(text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`) Keys(`Key1` `Key2` `Key3` `Key4` `Key5`) Values( `int(-5)` `uint(10)` `float(0.5)` `double(1.5)` `gender(100)` )"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_08_FTextHistory_NamedFormat_B()
        {
            AppConfig.DebugCheckMember = true;
            FText sourceFmt = GetTextBase("N0", "K0", "S0");
            FText argText1 = GetTextBase("N1", "K1", "S1");
            FText argText2 = GetTextBase("N2", "K2", "S2");

            FFormatArgumentValue arg1 = new() { Type = EFormatArgumentType.Text, TextValue = argText1 };
            FFormatArgumentValue arg2 = new() { Type = EFormatArgumentType.Text, TextValue = argText2 };

            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.NamedFormat;
            var textData = new FTextHistory_NamedFormat();
            text.TextData = textData;
            textData.SourceFmt = sourceFmt;
            textData.Arguments = new() { { new FString("Key1"), arg1 }, { new FString("Key2"), arg2 } };

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-named-format header=`Immutable` SourceFmt(text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`) Keys(`Key1` `Key2`) Values( `text(text-base header=`Immutable` Key=`K1` Namespace=`N1` SourceString=`S1`)` `text(text-base header=`Immutable` Key=`K2` Namespace=`N2` SourceString=`S2`)` )"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_08_FTextHistory_NamedFormat_C()
        {
            AppConfig.DebugCheckMember = true;
            FText sourceFmt = GetTextBase("N0", "K0", "S0");

            FFormatArgumentValue arg1 = new() { Type = EFormatArgumentType.Text, TextValue = GetTextOrdered("N1", "K1", "S1") };
            FFormatArgumentValue arg2 = new() { Type = EFormatArgumentType.Text, TextValue = GetTextOrdered("N2", "K2", "S2") };

            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.NamedFormat;
            var textData = new FTextHistory_NamedFormat();
            text.TextData = textData;

            textData.SourceFmt = sourceFmt;
            textData.Arguments = new() { { new FString("0"), arg1 }, { new FString("1"), arg2 } };

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-named-format header=`Immutable` SourceFmt(text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`) Keys(`0` `1`) Values( `text(text-ordered-format header=`Immutable` FormatText(text-base header=`Immutable` Key=`K1` Namespace=`N1` SourceString=`S1`) Values( `text(text-base header=`Immutable` Key=`K1` Namespace=`N1` SourceString=`S1`)` ))` `text(text-ordered-format header=`Immutable` FormatText(text-base header=`Immutable` Key=`K2` Namespace=`N2` SourceString=`S2`) Values( `text(text-base header=`Immutable` Key=`K2` Namespace=`N2` SourceString=`S2`)` ))` )"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_09_FTextHistory_OrderedFormat()
        {
            AppConfig.DebugCheckMember = true;
            FText formatText = GetTextBase("N0", "K0", "S0");

            FFormatArgumentValue arg1 = new() { Type = EFormatArgumentType.Int, IntValue = -5 };
            FFormatArgumentValue arg2 = new() { Type = EFormatArgumentType.UInt, UIntValue = 10 };
            FFormatArgumentValue arg3 = new() { Type = EFormatArgumentType.Float, FloatValue = 0.5f };
            FFormatArgumentValue arg4 = new() { Type = EFormatArgumentType.Double, DoubleValue = 1.5f };
            FFormatArgumentValue arg5 = new() { Type = EFormatArgumentType.Gender, UIntValue = 100 };

            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.OrderedFormat;
            var textData = new FTextHistory_OrderedFormat();
            text.TextData = textData;
            textData.FormatText = formatText;
            textData.Arguments = [arg1, arg2, arg3, arg4, arg5];

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-ordered-format header=`Immutable` FormatText(text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`) Values( `int(-5)` `uint(10)` `float(0.5)` `double(1.5)` `gender(100)` )"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_10_FTextHistory_ArgumentDataFormat_A()
        {
            AppConfig.DebugCheckMember = true;
            FText formatText = GetTextBase("N0", "K0", "S0");

            FFormatArgumentData arg1 = new() { ArgumentNameStr = new("Arg1"), ArgumentValueType = EFormatArgumentType.Int, ArgumentValueInt = -5 };
            FFormatArgumentData arg2 = new() { ArgumentNameStr = new("Arg2"), ArgumentValueType = EFormatArgumentType.Float, ArgumentValueFloat = 0.5f };
            FFormatArgumentData arg3 = new() { ArgumentNameStr = new("Arg3"), ArgumentValueType = EFormatArgumentType.Double, ArgumentValueDouble = 1.5f };
            FFormatArgumentData arg4 = new() { ArgumentNameStr = new("Arg4"), ArgumentValueType = EFormatArgumentType.Gender, ArgumentValueGender = ETextGender.Feminine };

            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.ArgumentFormat;
            var textData = new FTextHistory_ArgumentDataFormat();
            text.TextData = textData;
            textData.FormatText = formatText;
            textData.Arguments = [arg1, arg2, arg3, arg4];

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-argument-format header=`Immutable` FormatText(text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`) Keys( `Arg1` `Arg2` `Arg3` `Arg4` ) Values( `int -5` `float 0.5` `double 1.5` `gender Feminine` )"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_11_FTextHistory_ArgumentDataFormat_B()
        {
            AppConfig.DebugCheckMember = true;
            FText formatText = GetTextBase("N0", "K0", "S0");
            FText argText1 = GetTextBase("N1", "K1", "S1");
            FText argText2 = GetTextBase("N2", "K2", "S2");

            FFormatArgumentData arg1 = new() { ArgumentValueType = EFormatArgumentType.Text, ArgumentValue = argText1, ArgumentNameStr = new("Arg1") };
            FFormatArgumentData arg2 = new() { ArgumentValueType = EFormatArgumentType.Text, ArgumentValue = argText2, ArgumentNameStr = new("Arg2") };

            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.ArgumentFormat;
            var textData = new FTextHistory_ArgumentDataFormat();
            text.TextData = textData;
            textData.FormatText = formatText;
            textData.Arguments = [arg1, arg2];

            using TransferReader transferReader = new TransferReader();
            using MemoryStream outputStream = new MemoryStream();
            using BinaryWriter writer = new BinaryWriter(outputStream);
            using Transfer transferWriter = new TransferWriter(writer, transferReader);

            text.Move(transferWriter);

            string line = text.ToSimpleString();

            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-argument-format header=`Immutable` FormatText(text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`) Keys( `Arg1` `Arg2` ) Values( `text text-base header=`Immutable` Key=`K1` Namespace=`N1` SourceString=`S1`` `text text-base header=`Immutable` Key=`K2` Namespace=`N2` SourceString=`S2`` )"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        #region Private
        private FText GetTextBase(string ns, string key, string source)
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.Base;
            FTextHistory_Base data = new();
            text.TextData = data;

            data.Namespace = new(ns);
            data.Key = new(key);
            data.SourceString = new(source);
            return text;
        }

        private FText GetTextOrdered(string ns, string key, string source)
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.OrderedFormat;
            FTextHistory_OrderedFormat data = new();
            text.TextData = data;
            data.FormatText = GetTextBase(ns, key, source);
            data.Arguments.Add(new() { Type = EFormatArgumentType.Text, TextValue = GetTextBase(ns, key, source) });
            return text;
        }
        #endregion
    }
}
