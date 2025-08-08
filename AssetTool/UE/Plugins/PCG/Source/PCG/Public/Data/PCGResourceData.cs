namespace AssetTool
{
    [JsonAsset("PCGResourceData")]
    public class UPCGResourceData : UPCGData
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}