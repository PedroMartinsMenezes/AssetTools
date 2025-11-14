namespace AssetTool
{
    [JsonAsset("DynamicBlueprintBinding")]
    public class UDynamicBlueprintBinding : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}