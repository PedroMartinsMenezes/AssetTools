namespace AssetTool
{
    [JsonAsset("EnhancedInputActionDelegateBinding")]
    public class UEnhancedInputActionDelegateBinding : UInputDelegateBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("EnhancedInputActionValueBinding")]
    public class UEnhancedInputActionValueBinding : UInputDelegateBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}