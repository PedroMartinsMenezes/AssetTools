namespace AssetTool
{
    public class FEnhancedInputActionEventBinding : FInputBindingHandle
    {
        public UInt32 Action;
        public UInt32 TriggerEvent; //ou byte
    }

    public static class FEnhancedInputActionEventBindingExt
    {
        public static void Write(this BinaryWriter writer, FEnhancedInputActionEventBinding item)
        {
            writer.Write((FInputBindingHandle)item);
        }

        public static FEnhancedInputActionEventBinding Read(this BinaryReader reader, FEnhancedInputActionEventBinding item)
        {
            reader.Read((FInputBindingHandle)item);
            reader.Read(ref item.Action);
            reader.Read(ref item.TriggerEvent);
            return item;
        }
    }
}
