namespace AssetTool
{
    [JsonAsset("PCGStaticMeshDataInterface")]
    public class UPCGStaticMeshDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGStaticMeshDataProvider")]
    public class UPCGStaticMeshDataProvider : UPCGComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}