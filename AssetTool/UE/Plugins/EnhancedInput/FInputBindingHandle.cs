namespace AssetTool
{
    public class FInputBindingHandle
    {
        public UInt32 Handle;

        public FInputBindingHandle Read(BinaryReader reader)
        {
            reader.Read(ref Handle);
            return this;
        }
        public void Write(BinaryWriter writer)
        {
            writer.Write(Handle);
        }
    }
}
