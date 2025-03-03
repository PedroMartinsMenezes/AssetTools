namespace AssetTool
{
    [JsonAsset("PCGLoadDataTableSettings")]
    public class UPCGLoadDataTableSettings : UPCGExternalDataSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}