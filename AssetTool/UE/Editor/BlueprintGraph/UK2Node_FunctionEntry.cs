namespace AssetTool
{
    [Location("void UK2Node_FunctionEntry::Serialize(FArchive& Ar)")]
    public class UK2Node_FunctionEntry : UK2Node_FunctionTerminator
    {
        public const string TypeName = "K2Node_FunctionEntry";

        public new UK2Node_FunctionEntry Read(BinaryReader reader)
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
