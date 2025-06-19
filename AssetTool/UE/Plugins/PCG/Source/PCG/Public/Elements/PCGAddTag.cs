namespace AssetTool
{
    [JsonAsset("PCGAddTagSettings")]
    public class UPCGAddTagSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}