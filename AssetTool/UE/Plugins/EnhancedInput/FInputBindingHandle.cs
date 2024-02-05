namespace AssetTool
{
    public class FInputBindingHandle : FField
    {
        public UInt32 Handle;
    }

    public static class FInputBindingHandleExt
    {
        public static void Write(this BinaryWriter writer, FInputBindingHandle item)
        {

        }

        public static FInputBindingHandle Read(this BinaryReader reader, FInputBindingHandle item)
        {
            reader.Read(ref item.Handle);
            return item;
        }
    }
}
