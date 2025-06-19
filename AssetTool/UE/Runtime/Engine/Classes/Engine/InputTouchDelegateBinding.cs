namespace AssetTool
{
    [JsonAsset("InputTouchDelegateBinding")]
    public class UInputTouchDelegateBinding : UInputDelegateBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}