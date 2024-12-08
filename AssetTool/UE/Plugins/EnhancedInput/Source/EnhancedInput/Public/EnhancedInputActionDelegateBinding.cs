namespace AssetTool
{
    [JsonAsset("EnhancedInputActionDelegateBinding")]
    public class UEnhancedInputActionDelegateBinding : UInputDelegateBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputActionValueBinding")]
    public class UEnhancedInputActionValueBinding : UInputDelegateBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}