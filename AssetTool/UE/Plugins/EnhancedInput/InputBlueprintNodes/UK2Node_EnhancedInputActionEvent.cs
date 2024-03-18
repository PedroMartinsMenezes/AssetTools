namespace AssetTool
{
    public class UK2Node_EnhancedInputActionEvent : UK2Node_Event
    {
        public new UK2Node_EnhancedInputActionEvent Read(BinaryReader reader)
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
