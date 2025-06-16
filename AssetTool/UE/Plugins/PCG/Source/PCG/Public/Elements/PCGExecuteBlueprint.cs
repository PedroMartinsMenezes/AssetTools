namespace AssetTool
{
    [JsonAsset("PCGBlueprintElement")]
    public class UPCGBlueprintElement : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGBlueprintSettings")]
    public class UPCGBlueprintSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}