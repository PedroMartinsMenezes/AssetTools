namespace AssetTool
{
    [JsonAsset("InputKeyDelegateBinding")]
    public class UInputKeyDelegateBinding : UInputDelegateBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}