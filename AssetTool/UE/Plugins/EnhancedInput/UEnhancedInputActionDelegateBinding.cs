namespace AssetTool
{
    public class UEnhancedInputActionDelegateBinding : UInputDelegateBinding
    {
        public const string TypeName = "EnhancedInputActionDelegateBinding";

        public new UEnhancedInputActionDelegateBinding Move(Transfer transfer) => (UEnhancedInputActionDelegateBinding)base.Move(transfer);
    }
}
