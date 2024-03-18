namespace AssetTool
{
    public class FEnhancedInputActionEventBinding : FInputBindingHandle
    {
        public UInt32 Action;
        public UInt32 TriggerEvent;

        public new FEnhancedInputActionEventBinding Read(BinaryReader reader)
        {
            base.Read(reader);
            reader.Read(ref Action);
            reader.Read(ref TriggerEvent);
            return this;
        }
        public new void Write(BinaryWriter writer)
        {
            base.Write(writer);
            writer.Write(Action);
            writer.Write(TriggerEvent);
        }
    }
}
