namespace AssetTool
{
    [JsonAsset("PCGDuplicatePointSettings")]
    public class UPCGDuplicatePointSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}