namespace AssetTool
{
    [Location("void UK2Node_CallFunction::Serialize(FArchive& Ar)")]
    public class UK2Node_CallMaterialParameterCollectionFunction : UK2Node_CallFunction
    {
        public new const string TypeName = "K2Node_CallMaterialParameterCollectionFunction";

        public new UK2Node_CallMaterialParameterCollectionFunction Read(BinaryReader reader)
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
