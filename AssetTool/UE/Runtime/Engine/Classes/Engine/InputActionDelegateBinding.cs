namespace AssetTool
{
    [JsonAsset("InputActionDelegateBinding")]
    public class UInputActionDelegateBinding : UInputDelegateBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}