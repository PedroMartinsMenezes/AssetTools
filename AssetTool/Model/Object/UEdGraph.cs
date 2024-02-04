using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraph::Serialize(FStructuredArchiveRecord Record)")]
    public class UEdGraph : UObject
    {
    }

    public static class UEdGraphExt
    {
        public static void Write(this BinaryWriter writer, UEdGraph item)
        {
            writer.Write((UObject)item);
        }

        public static UEdGraph Read(this BinaryReader reader, UEdGraph item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}
