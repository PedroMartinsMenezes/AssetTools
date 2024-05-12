namespace AssetTool
{
    public class UInputDelegateBinding : UDynamicBlueprintBinding
    {
        public new UInputDelegateBinding Move(Transfer transfer) => (UInputDelegateBinding)base.Move(transfer);
    }
}
