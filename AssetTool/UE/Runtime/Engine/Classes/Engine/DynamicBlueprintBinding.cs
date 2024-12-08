namespace AssetTool
{
    [JsonAsset("DynamicBlueprintBinding")]
    public class UDynamicBlueprintBinding : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}