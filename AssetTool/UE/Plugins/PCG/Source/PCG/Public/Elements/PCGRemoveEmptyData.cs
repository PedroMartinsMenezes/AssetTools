namespace AssetTool
{
    [JsonAsset("PCGRemoveEmptyDataSettings")]
    public class UPCGRemoveEmptyDataSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}