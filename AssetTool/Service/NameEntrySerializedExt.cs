using AssetTool.Model;

namespace AssetTool.Service
{
    public static class NameEntrySerializedExt
    {
        public static void Write(this BinaryWriter writer, List<FNameEntrySerialized> list)
        {
            list.ForEach(item => writer.Write(item));
        }

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
    }
}
