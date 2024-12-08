namespace AssetTool
{
    [JsonAsset("InputDelegateBinding")]
    public class UInputDelegateBinding : UDynamicBlueprintBinding
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}