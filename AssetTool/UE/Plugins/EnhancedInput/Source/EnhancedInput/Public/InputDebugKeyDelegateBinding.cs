namespace AssetTool
{
    [JsonAsset("InputDebugKeyDelegateBinding")]
    public class UInputDebugKeyDelegateBinding : UInputDelegateBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}