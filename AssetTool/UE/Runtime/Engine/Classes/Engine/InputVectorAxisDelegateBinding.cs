namespace AssetTool
{
    [JsonAsset("InputVectorAxisDelegateBinding")]
    public class UInputVectorAxisDelegateBinding : UInputAxisKeyDelegateBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}