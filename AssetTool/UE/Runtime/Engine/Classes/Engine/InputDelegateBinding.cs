namespace AssetTool
{
    [JsonAsset("InputDelegateBinding")]
    public class UInputDelegateBinding : UDynamicBlueprintBinding
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}