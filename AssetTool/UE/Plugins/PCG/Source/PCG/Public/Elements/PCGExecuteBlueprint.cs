namespace AssetTool
{
    [JsonAsset("PCGBlueprintElement")]
    public class UPCGBlueprintElement : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGBlueprintSettings")]
    public class UPCGBlueprintSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}