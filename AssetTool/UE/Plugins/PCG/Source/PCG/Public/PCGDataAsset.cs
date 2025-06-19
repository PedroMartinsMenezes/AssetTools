namespace AssetTool
{
    [JsonAsset("PCGDataAsset")]
    public class UPCGDataAsset : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}