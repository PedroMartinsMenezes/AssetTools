namespace AssetTool
{
    [JsonAsset("PCGLoadDataTableSettings")]
    public class UPCGLoadDataTableSettings : UPCGExternalDataSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}