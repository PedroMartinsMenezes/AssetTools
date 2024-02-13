namespace AssetTool
{
    [Location("void USCS_Node::Serialize(FArchive& Ar)")]
    public class USCS_Node : UObject
    {
        public const string TypeName = "SCS_Node";
    }

    public static class USCS_NodeExt
    {
        public static void Write(this BinaryWriter writer, USCS_Node item)
        {
            writer.Write((UObject)item);
        }

        public static USCS_Node Read(this BinaryReader reader, USCS_Node item)
        {
            reader.Read((UObject)item);
            return item;
        }
    }
}
