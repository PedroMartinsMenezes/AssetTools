namespace AssetTool
{
    [Location("void UK2Node::Serialize(FArchive& Ar)")]
    public class UK2Node_VariableSet : UK2Node_Variable
    {
        public new const string TypeName = "K2Node_VariableSet";

        public new UK2Node_VariableSet Read(BinaryReader reader)
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
