namespace AssetTool
{
    public class UEdGraphNode_Comment : UEdGraphNode
    {
        public const string TypeName = "EdGraphNode_Comment";
    }

    public static class UEdGraphNode_CommentExt
    {
        public static void Write(this BinaryWriter writer, UEdGraphNode_Comment item)
        {
            writer.Write((UEdGraphNode)item);
        }

        public static UEdGraphNode_Comment Read(this BinaryReader reader, UEdGraphNode_Comment item)
        {
            reader.Read((UEdGraphNode)item);
            return item;
        }
    }
}
