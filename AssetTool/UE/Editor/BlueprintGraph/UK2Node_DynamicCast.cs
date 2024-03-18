namespace AssetTool
{
    [Location("void UK2Node_DynamicCast::Serialize(FArchive& Ar)")]
    public class UK2Node_DynamicCast : UK2Node
    {
        public const string TypeName = "K2Node_DynamicCast";

        public byte PureState;

        public new UK2Node_DynamicCast Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref PureState);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(PureState);
        }
    }
}
