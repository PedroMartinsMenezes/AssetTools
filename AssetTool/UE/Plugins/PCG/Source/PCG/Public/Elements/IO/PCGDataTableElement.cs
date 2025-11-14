namespace AssetTool
{
    [JsonAsset("PCGLoadDataTableSettings")]
    public class UPCGLoadDataTableSettings : UPCGExternalDataSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}