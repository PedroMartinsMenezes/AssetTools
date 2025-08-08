namespace AssetTool
{
    [JsonAsset("PCGExportSelectedAttributesSettings")]
    public class UPCGExportSelectedAttributesSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}