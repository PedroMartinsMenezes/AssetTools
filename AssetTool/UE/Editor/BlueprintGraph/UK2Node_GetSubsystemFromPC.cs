namespace AssetTool
{
    public class UK2Node_GetSubsystemFromPC : UK2Node_GetSubsystem
    {
        public const string TypeName = "K2Node_GetSubsystemFromPC";

        public new UK2Node_GetSubsystemFromPC Read(BinaryReader reader)
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
