namespace AssetTool
{
    [JsonAsset("InputVectorAxisDelegateBinding")]
    public class UInputVectorAxisDelegateBinding : UInputAxisKeyDelegateBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}