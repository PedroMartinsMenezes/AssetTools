namespace AssetTool
{
    [JsonAsset("DynamicBlueprintBinding")]
    public class UDynamicBlueprintBinding : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}