namespace AssetTool
{
    [JsonAsset("PCGDataAsset")]
    public class UPCGDataAsset : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}