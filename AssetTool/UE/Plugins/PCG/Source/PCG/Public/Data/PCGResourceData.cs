namespace AssetTool
{
    [JsonAsset("PCGResourceData")]
    public class UPCGResourceData : UPCGData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}