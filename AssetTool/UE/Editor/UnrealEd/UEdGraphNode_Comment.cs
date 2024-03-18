namespace AssetTool
{
    public class UEdGraphNode_Comment : UEdGraphNode
    {
        public const string TypeName = "EdGraphNode_Comment";

        public new UEdGraphNode_Comment Read(BinaryReader reader)
        {
            base.Read(reader);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
        }
    }
}
