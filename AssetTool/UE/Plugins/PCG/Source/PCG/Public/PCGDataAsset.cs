namespace AssetTool
{
    [JsonAsset("PCGDataAsset")]
    public class UPCGDataAsset : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}