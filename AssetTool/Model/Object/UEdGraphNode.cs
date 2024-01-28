using System.ComponentModel;

namespace AssetTool.Model
{
    [Description("void UEdGraphNode::Serialize(FArchive& Ar)")]
    public class UEdGraphNode : UObject
    {
    }

    public static class UEdGraphNodeExt
    {
        public static void Write(this BinaryWriter writer, UEdGraphNode item)
        {
            writer.Write((UObject)item);
        }

        public static UEdGraphNode Read(this BinaryReader reader, UEdGraphNode item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}
