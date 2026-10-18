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

    public class FEnhancedInputActionEventBinding : FInputBindingHandle
    {
        public UInt32 Action;
        public UInt32 TriggerEvent;

        public override FInputBindingHandle Move(Transfer transfer)
        {
            base.Move(transfer);
            transfer.Move(ref Action);
            transfer.Move(ref TriggerEvent);
            return this;
        }
    }

    public class FEnhancedInputActionValueBinding : FInputBindingHandle
    {
    }
}
