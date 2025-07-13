namespace AssetTool
{
    [JsonAsset("BlueprintRuntimeSettings")]
    public class UBlueprintRuntimeSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}