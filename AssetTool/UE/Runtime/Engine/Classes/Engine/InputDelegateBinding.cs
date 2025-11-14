namespace AssetTool
{
    [JsonAsset("InputDelegateBinding")]
    public class UInputDelegateBinding : UDynamicBlueprintBinding
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}