namespace AssetTool
{
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
}
