namespace AssetTool
{
    [Location("void UK2Node_CallFunction::Serialize(FArchive& Ar)")]
    public class UK2Node_CallFunction : UK2Node
    {
        public const string TypeName = "K2Node_CallFunction";

        public new UK2Node_CallFunction Read(BinaryReader reader)
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
