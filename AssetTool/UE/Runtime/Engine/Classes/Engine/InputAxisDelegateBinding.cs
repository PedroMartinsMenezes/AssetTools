namespace AssetTool
{
    [JsonAsset("InputAxisDelegateBinding")]
    public class UInputAxisDelegateBinding : UInputDelegateBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}