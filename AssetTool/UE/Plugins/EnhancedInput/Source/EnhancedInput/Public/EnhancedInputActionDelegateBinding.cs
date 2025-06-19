namespace AssetTool
{
    [JsonAsset("EnhancedInputActionDelegateBinding")]
    public class UEnhancedInputActionDelegateBinding : UInputDelegateBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputActionValueBinding")]
    public class UEnhancedInputActionValueBinding : UInputDelegateBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}