namespace AssetTool
{
    [JsonAsset("PCGDynamicMeshData")]
    public class UPCGDynamicMeshData : UPCGSpatialData
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}