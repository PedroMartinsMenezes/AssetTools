namespace AssetTool
{
    [JsonAsset("PCGDeleteTagsSettings")]
    public class UPCGDeleteTagsSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}