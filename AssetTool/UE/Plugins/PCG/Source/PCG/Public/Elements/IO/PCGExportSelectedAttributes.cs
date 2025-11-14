namespace AssetTool
{
    [JsonAsset("PCGExportSelectedAttributesSettings")]
    public class UPCGExportSelectedAttributesSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}