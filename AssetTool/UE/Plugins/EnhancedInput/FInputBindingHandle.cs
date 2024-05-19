namespace AssetTool
{
    public class FInputBindingHandle
    {
        public UInt32 Handle;

        public virtual FInputBindingHandle Move(Transfer transfer)
        {
            transfer.Move(ref Handle);
            return this;
        }
    }
}
