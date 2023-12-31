using System.ComponentModel;

namespace AssetTool
{
    [Description("Offset: 406. Size: Dynamic")]
    public class FNameEntrySerialized
    {
        public FString Name = string.Empty;

        public UInt16[] DummyHashes = new UInt16[] { 0, 0 };
    }

    public static class NameEntrySerializedExt
    {
        public static void Write(this BinaryWriter writer, FNameEntrySerialized item)
        {
            writer.Write(item.Name);
            writer.Write(item.DummyHashes[0]);
            writer.Write(item.DummyHashes[1]);
        }

        public static void Add(this List<FNameEntrySerialized> list, string name, ushort a, ushort b)
        {
            list.Add(new() { Name = name, DummyHashes = new ushort[] { a, b } });
        }

        public static FNameEntrySerialized Read(this BinaryReader reader, FNameEntrySerialized item)
        {
            reader.Read(ref item.Name);
            reader.Read(ref item.DummyHashes[0]);
            reader.Read(ref item.DummyHashes[1]);
            return item;
        }

        public static List<FNameEntrySerialized> ReadList(this BinaryReader reader, int count, FNameEntrySerialized item)
        {
            return Enumerable.Range(0, count).Select(x => reader.Read(new FNameEntrySerialized())).ToList();
        }
    }
}
