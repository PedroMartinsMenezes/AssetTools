namespace AssetTool
{
    [JsonAsset("InputAxisDelegateBinding")]
    public class UInputAxisDelegateBinding : UInputDelegateBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}