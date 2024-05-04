namespace AssetTool
{
    [Location("void UK2Node::Serialize(FArchive& Ar)")]
    public class UK2Node_ExecutionSequence : UK2Node
    {
        public const string TypeName = "K2Node_ExecutionSequence";

        public new UK2Node_ExecutionSequence Read(BinaryReader reader)
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
