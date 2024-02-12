using System.ComponentModel;

namespace AssetTool
{
    [Description("void UEdGraphNode::Serialize(FArchive& Ar)")]
    public class UEdGraphNode : UObject
    {
        [Sized] public List<UEdGraphPin> Pins;
    }

    public static class UEdGraphNodeExt
    {
        public static void Write(this BinaryWriter writer, UEdGraphNode item)
        {
            writer.Write((UObject)item);

            writer.Write(item.Pins, UEdGraphPin.EPinResolveType.OwningNode);
        }

        public static UEdGraphNode Read(this BinaryReader reader, UEdGraphNode item)
        {
            reader.Read((UObject)item);

            reader.Read(ref item.Pins, UEdGraphPin.EPinResolveType.OwningNode);

            return item;
        }
    }
}
