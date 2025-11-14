namespace AssetTool
{
    [JsonAsset("PCGStaticMeshDataInterface")]
    public class UPCGStaticMeshDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGStaticMeshDataProvider")]
    public class UPCGStaticMeshDataProvider : UPCGComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}