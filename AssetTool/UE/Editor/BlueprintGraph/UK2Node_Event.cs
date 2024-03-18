namespace AssetTool
{
    [Location("void UK2Node_Event::Serialize(FArchive& Ar)")]
    public class UK2Node_Event : UK2Node_EditablePinBase
    {
        public const string TypeName = "K2Node_Event";

        public new UK2Node_Event Read(BinaryReader reader)
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
