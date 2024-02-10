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
            writer.WriteList(item.Pins);
        }

        public static UEdGraphNode Read(this BinaryReader reader, UEdGraphNode item)
        {
            reader.Read((UObject)item); //82970 OK

            reader.Read(ref item.Pins, UEdGraphPin.EPinResolveType.OwningNode);

            return item; //? <> 83615
        }
    }
}
