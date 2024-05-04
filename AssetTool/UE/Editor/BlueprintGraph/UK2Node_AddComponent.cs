namespace AssetTool
{
    [Location("void UK2Node_AddComponent::Serialize(FArchive& Ar)")]
    public class UK2Node_AddComponent : UK2Node_CallFunction
    {
        public new const string TypeName = "K2Node_AddComponent";

        public new UK2Node_AddComponent Read(BinaryReader reader)
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
