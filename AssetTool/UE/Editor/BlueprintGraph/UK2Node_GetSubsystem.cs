namespace AssetTool
{
    [Location("void UK2Node_GetSubsystem::Serialize( FArchive& Ar )")]
    public class UK2Node_GetSubsystem : UK2Node
    {
        public new UK2Node_GetSubsystem Read(BinaryReader reader)
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
