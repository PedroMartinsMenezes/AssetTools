namespace AssetTool
{
    [JsonAsset("PCGDuplicatePointSettings")]
    public class UPCGDuplicatePointSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}