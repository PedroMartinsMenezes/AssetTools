namespace AssetTool
{
    [JsonAsset("PCGRemoveEmptyDataSettings")]
    public class UPCGRemoveEmptyDataSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}