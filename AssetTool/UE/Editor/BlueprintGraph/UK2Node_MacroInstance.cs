namespace AssetTool
{
    [Location("void UK2Node_MacroInstance::Serialize(FArchive& Ar)")]
    public class UK2Node_MacroInstance : UK2Node_Tunnel
    {
        public const string TypeName = "K2Node_MacroInstance";

        public new UK2Node_MacroInstance Read(BinaryReader reader)
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
