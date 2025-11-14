namespace AssetTool
{
    [JsonAsset("PCGStaticMeshResourceData")]
    public class UPCGStaticMeshResourceData : UPCGResourceData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}