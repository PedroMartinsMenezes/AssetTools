namespace AssetTool
{
    [JsonAsset("PCGExternalDataSettings")]
    public class UPCGExternalDataSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}