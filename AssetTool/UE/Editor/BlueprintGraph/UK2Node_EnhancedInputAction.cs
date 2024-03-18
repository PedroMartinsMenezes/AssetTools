namespace AssetTool
{
    public class UK2Node_EnhancedInputAction : UK2Node
    {
        public const string TypeName = "K2Node_EnhancedInputAction";

        public new UK2Node_EnhancedInputAction Read(BinaryReader reader)
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
