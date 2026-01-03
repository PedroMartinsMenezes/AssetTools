using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace AssetTool.Test.InfraTest
{
    //[Ignore("Irrelevant")]
    [SetCulture("")]
    [SetUICulture("")]
    [NonParallelizable]
    public class SerializationTests : TestBase
    {
        private TransferReader transferReader;
        private MemoryStream outputStream;
        private BinaryWriter writer;
        private Transfer transferWriter;

        [SetUp]
        public void Setup()
        {
            AppConfig.DebugCheckMember = true;
            transferReader = new TransferReader();
            outputStream = new MemoryStream();
            writer = new BinaryWriter(outputStream);
            transferWriter = new TransferWriter(writer, transferReader);
        }

        [TearDown]
        public override void TearDown()
        {
            transferReader.Dispose();
            outputStream.Dispose();
            writer.Dispose();
            transferWriter.Dispose();
            base.TearDown();
        }

        [Test]
        public void Test_01_FTextHistory_Base()
        {
            FText text = GetTextBase("N0", "K0", "S0");

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_02_FTextHistory_AsDate()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsDate;

            text.TextData = new FTextHistory_AsDate()
            {
                SourceDateTime = new FDateTime { Ticks = new DateTime(2025, 12, 31).Ticks },
                DateStyle = EDateTimeStyle.Full,
                TimeZone = new("UTC"),
                CultureName = new("en-US")
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-as-date header=`Immutable` SourceDateTime=`639027360000000000` DateStyle=`Full` TimeZone=`UTC` CultureName=`en-US`"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_03_FTextHistory_AsTime()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsTime;

            text.TextData = new FTextHistory_AsTime()
            {
                SourceDateTime = new FDateTime { Ticks = new DateTime(2025, 12, 31).Ticks },
                TimeStyle = EDateTimeStyle.Full,
                TimeZone = new("UTC"),
                CultureName = new("en-US")
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-as-time header=`Immutable` SourceDateTime=`639027360000000000` TimeStyle=`Full` TimeZone=`UTC` CultureName=`en-US`"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_04_FTextHistory_AsDateTime()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsDateTime;

            text.TextData = new FTextHistory_AsDateTime()
            {
                SourceDateTime = new FDateTime { Ticks = new DateTime(2025, 12, 31).Ticks },
                DateStyle = EDateTimeStyle.Full,
                TimeStyle = EDateTimeStyle.Full,
                TimeZone = new("UTC"),
                CultureName = new("en-US")
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-as-date-time header=`Immutable` SourceDateTime=`639027360000000000` DateStyle=`Full` TimeStyle=`Full` TimeZone=`UTC` CultureName=`en-US`"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_05_FTextHistory_StringTableEntry()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.StringTableEntry;

            text.TextData = new FTextHistory_StringTableEntry()
            {
                TableId = new FName("None"),
                Key = new FString("MyKey")
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-string-table-entry header=`Immutable` TableId=`None` Key=`MyKey`"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_06_FTextHistory_TextGenerator()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.TextGenerator;

            text.TextData = new FTextHistory_TextGenerator
            {
                GeneratorTypeID = NewFName("MyType"),
                GeneratorContents = [1, 2, 3]
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-generator header=`Immutable` GeneratorTypeID=`MyType` GeneratorContents=`1 2 3`"));
            Assert.That(text.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        private FName NewFName(string value)
        {
            transferReader.GlobalNames.NameToIndex[value] = (uint)transferReader.GlobalNames.NameToIndex.Count + 1u;
            return new FName(value);
        }

        [Test]
        public void Test_07_FTextHistory_NamedFormat_A()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.NamedFormat;

            text.TextData = new FTextHistory_NamedFormat()
            {
                SourceFmt = GetTextBase("N0", "K0", "S0"),
                Arguments = GetArgumentsDict()
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-named-format header=`Immutable` SourceFmt«text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`» Keys(`Key1` `Key2` `Key3` `Key4` `Key5`) Values« `int(-5)` `uint(10)` `float(0.5)` `double(1.5)` `gender(100)` »"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_08_FTextHistory_NamedFormat_B()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.NamedFormat;

            text.TextData = new FTextHistory_NamedFormat()
            {
                SourceFmt = GetTextBase("N0", "K0", "S0"),
                Arguments = new()
                {
                    { new FString("Key1"), new() { Type = EFormatArgumentType.Text, TextValue = GetTextBase("N1", "K1", "S1") } },
                    { new FString("Key2"), new() { Type = EFormatArgumentType.Text, TextValue = GetTextBase("N2", "K2", "S2") } }
                }
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-named-format header=`Immutable` SourceFmt«text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`» Keys(`Key1` `Key2`) Values« `text(«text-base header=`Immutable` Key=`K1` Namespace=`N1` SourceString=`S1`»)` `text(«text-base header=`Immutable` Key=`K2` Namespace=`N2` SourceString=`S2`»)` »"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_08_FTextHistory_NamedFormat_C()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.NamedFormat;

            text.TextData = new FTextHistory_NamedFormat()
            {
                SourceFmt = GetTextBase("N0", "K0", "S0"),
                Arguments = new()
                {
                    { new FString("0"), new() { Type = EFormatArgumentType.Text, TextValue = GetTextOrdered("N1", "K1", "S1") } },
                    { new FString("1"), new() { Type = EFormatArgumentType.Text, TextValue = GetTextOrdered("N2", "K2", "S2") } }
                }
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-named-format header=`Immutable` SourceFmt«text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`» Keys(`0` `1`) Values« `text(«text-ordered-format header=`Immutable` FormatText«text-base header=`Immutable` Key=`K1` Namespace=`N1` SourceString=`S1`» Values« `text(«text-base header=`Immutable` Key=`K1` Namespace=`N1` SourceString=`S1`»)` »»)` `text(«text-ordered-format header=`Immutable` FormatText«text-base header=`Immutable` Key=`K2` Namespace=`N2` SourceString=`S2`» Values« `text(«text-base header=`Immutable` Key=`K2` Namespace=`N2` SourceString=`S2`»)` »»)` »"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_09_FTextHistory_OrderedFormat()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.OrderedFormat;

            text.TextData = new FTextHistory_OrderedFormat()
            {
                FormatText = GetTextBase("N0", "K0", "S0"),
                Arguments = GetArgumentsList()
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-ordered-format header=`Immutable` FormatText«text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`» Values« `int(-5)` `uint(10)` `float(0.5)` `double(1.5)` `gender(100)` »"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_10_FTextHistory_ArgumentDataFormat_A()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.ArgumentFormat;

            text.TextData = new FTextHistory_ArgumentDataFormat()
            {
                FormatText = GetTextBase("N0", "K0", "S0"),
                Arguments = GetArgumentsDataList()
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-argument-format header=`Immutable` FormatText«text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`» Keys( `Arg1` `Arg2` `Arg3` `Arg4` ) Values« `int -5` `float 0.5` `double 1.5` `gender Feminine` »"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_11_FTextHistory_ArgumentDataFormat_B()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.ArgumentFormat;

            text.TextData = new FTextHistory_ArgumentDataFormat()
            {
                FormatText = GetTextBase("N0", "K0", "S0"),
                Arguments =
                [
                    new() { ArgumentValueType = EFormatArgumentType.Text, ArgumentValue = GetTextBase("N1", "K1", "S1"), ArgumentNameStr = new("Arg1") },
                    new() { ArgumentValueType = EFormatArgumentType.Text, ArgumentValue = GetTextBase("N2", "K2", "S2"), ArgumentNameStr = new("Arg2") }
                ]
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-argument-format header=`Immutable` FormatText«text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`» Keys( `Arg1` `Arg2` ) Values« `text text-base header=`Immutable` Key=`K1` Namespace=`N1` SourceString=`S1`` `text text-base header=`Immutable` Key=`K2` Namespace=`N2` SourceString=`S2`` »"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        [TestCase(EFormatArgumentType.Int, -5, "int(-5)")]
        [TestCase(EFormatArgumentType.UInt, 10u, "uint(10)")]
        [TestCase(EFormatArgumentType.Float, 0.5f, "float(0.5)")]
        [TestCase(EFormatArgumentType.Double, 1.5, "double(1.5)")]
        [TestCase(EFormatArgumentType.Gender, 100u, "gender(100)")]
        public void Test_12_FTextHistory_AsNumber(EFormatArgumentType type, object value, string textValue)
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsNumber;

            text.TextData = new FTextHistory_AsNumber()
            {
                SourceValue = GetArgument(type, value),
                bHasFormatOptions = true,
                Options = GetOptions(),
                CultureName = new("en-US")
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo($"text-as-number header=`Immutable` SourceValue«{textValue}» bHasFormatOptions=`True` CultureName=`en-US` Options=`True True HalfToZero 2 6 2 6`"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        [TestCase(EFormatArgumentType.Int, -5, "int(-5)")]
        [TestCase(EFormatArgumentType.UInt, 10u, "uint(10)")]
        [TestCase(EFormatArgumentType.Float, 0.5f, "float(0.5)")]
        [TestCase(EFormatArgumentType.Double, 1.5, "double(1.5)")]
        [TestCase(EFormatArgumentType.Gender, 100u, "gender(100)")]
        public void Test_13_FTextHistory_AsPercent(EFormatArgumentType type, object value, string textValue)
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsPercent;

            text.TextData = new FTextHistory_AsPercent()
            {
                SourceValue = GetArgument(type, value),
                bHasFormatOptions = true,
                Options = GetOptions(),
                CultureName = new("en-US")
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo($"text-as-percent header=`Immutable` SourceValue«{textValue}» bHasFormatOptions=`True` CultureName=`en-US` Options=`True True HalfToZero 2 6 2 6`"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        [TestCase(EFormatArgumentType.Int, -5, "int(-5)")]
        [TestCase(EFormatArgumentType.UInt, 10u, "uint(10)")]
        [TestCase(EFormatArgumentType.Float, 0.5f, "float(0.5)")]
        [TestCase(EFormatArgumentType.Double, 1.5, "double(1.5)")]
        [TestCase(EFormatArgumentType.Gender, 100u, "gender(100)")]
        public void Test_14_FTextHistory_AsCurrency(EFormatArgumentType type, object value, string textValue)
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.AsCurrency;

            text.TextData = new FTextHistory_AsCurrency()
            {
                SourceValue = GetArgument(type, value),
                bHasFormatOptions = true,
                Options = GetOptions(),
                CultureName = new("en-US"),
                CurrencyCode = new("USD")
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo($"text-as-currency header=`Immutable` SourceValue«{textValue}» bHasFormatOptions=`True` CultureName=`en-US` Options=`True True HalfToZero 2 6 2 6` CurrencyCode=`USD`"));
            Assert.That(clone.AutoCheck(transferReader, "", transferWriter.Stream, [0, transferWriter.Position]));
        }

        [Test]
        public void Test_15_FTextHistory_Transform()
        {
            FText text = new();
            text.Flags = ETextFlag.Immutable;
            text.HistoryType = ETextHistoryType.Transform;

            text.TextData = new FTextHistory_Transform()
            {
                SourceText = GetTextBase("N0", "K0", "S0"),
                TransformType = ETransformType.ToUpper
            };

            text.Move(transferWriter);
            string line = text.ToSimpleString();
            FText clone = FText.FromSimpleString(line);

            Assert.That(line, Is.EqualTo("text-transform header=`Immutable` SourceText«text-base header=`Immutable` Key=`K0` Namespace=`N0` SourceString=`S0`» TransformType=`ToUpper`"));
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

        private FNumberFormattingOptions GetOptions()
        {
            return new() { AlwaysSign = true, UseGrouping = true, RoundingMode = ERoundingMode.HalfToZero, MinimumIntegralDigits = 2, MaximumIntegralDigits = 6, MinimumFractionalDigits = 2, MaximumFractionalDigits = 6 };
        }

        private static Dictionary<FString, FFormatArgumentValue> GetArgumentsDict()
        {
            return new()
            {
                { new FString("Key1"), new() { Type = EFormatArgumentType.Int, IntValue = -5 } },
                { new FString("Key2"), new() { Type = EFormatArgumentType.UInt, UIntValue = 10 } },
                { new FString("Key3"), new() { Type = EFormatArgumentType.Float, FloatValue = 0.5f } },
                { new FString("Key4"), new() { Type = EFormatArgumentType.Double, DoubleValue = 1.5f } },
                { new FString("Key5"), new() { Type = EFormatArgumentType.Gender, UIntValue = 100 } }
            };
        }

        private static List<FFormatArgumentValue> GetArgumentsList()
        {
            return new()
            {
                new() { Type = EFormatArgumentType.Int, IntValue = -5 },
                new() { Type = EFormatArgumentType.UInt, UIntValue = 10 },
                new() { Type = EFormatArgumentType.Float, FloatValue = 0.5f },
                new() { Type = EFormatArgumentType.Double, DoubleValue = 1.5f },
                new() { Type = EFormatArgumentType.Gender, UIntValue = 100 }
            };
        }

        private static List<FFormatArgumentData> GetArgumentsDataList()
        {
            return new()
            {
                new() { ArgumentNameStr = new("Arg1"), ArgumentValueType = EFormatArgumentType.Int, ArgumentValueInt = -5 },
                new() { ArgumentNameStr = new("Arg2"), ArgumentValueType = EFormatArgumentType.Float, ArgumentValueFloat = 0.5f },
                new() { ArgumentNameStr = new("Arg3"), ArgumentValueType = EFormatArgumentType.Double, ArgumentValueDouble = 1.5f },
                new() { ArgumentNameStr = new("Arg4"), ArgumentValueType = EFormatArgumentType.Gender, ArgumentValueGender = ETextGender.Feminine }
            };
        }

        private static FFormatArgumentValue GetArgument(EFormatArgumentType type, object value)
        {
            return new()
            {
                Type = type,
                IntValue = type == EFormatArgumentType.Int ? (int)value : default,
                UIntValue = type is EFormatArgumentType.UInt or EFormatArgumentType.Gender ? (uint)value : default,
                FloatValue = type == EFormatArgumentType.Float ? (float)value : default,
                DoubleValue = type == EFormatArgumentType.Double ? (double)value : default,
            };
        }
        #endregion
    }
}
