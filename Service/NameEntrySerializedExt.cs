using AssetTool.Model;

namespace AssetTool.Service
{
    public static class NameEntrySerializedExt
    {
        public static void WriteString(this BinaryWriter writer, FNameEntrySerialized x)
        {
            writer.Write(x.NameSize);
            writer.Write(x.DummyHashes[0]);
            writer.Write(x.DummyHashes[1]);
            writer.Write(x.Name);
        }
    }
}
