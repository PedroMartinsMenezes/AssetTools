namespace AssetTool
{
    [Location("void UK2Node::Serialize(FArchive& Ar)")]
    public class UK2Node_Variable : UK2Node
    {
        public const string TypeName = "K2Node_Variable";

        public new UK2Node_Variable Read(BinaryReader reader)
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
