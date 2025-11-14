namespace AssetTool
{
    [JsonAsset("InputActionDelegateBinding")]
    public class UInputActionDelegateBinding : UInputDelegateBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}