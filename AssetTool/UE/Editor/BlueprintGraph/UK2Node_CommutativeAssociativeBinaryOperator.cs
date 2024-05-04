namespace AssetTool
{
    [Location("void UK2Node_CallFunction::Serialize(FArchive& Ar)")]
    public class UK2Node_CommutativeAssociativeBinaryOperator : UK2Node_CallFunction
    {
        public new const string TypeName = "K2Node_CommutativeAssociativeBinaryOperator";

        public new UK2Node_CommutativeAssociativeBinaryOperator Read(BinaryReader reader)
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
