namespace AssetTool
{
    [JsonAsset("PCGSkinnedMeshSpawnerDataInterface")]
    public class UPCGSkinnedMeshSpawnerDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSkinnedMeshSpawnerDataProvider")]
    public class UPCGSkinnedMeshSpawnerDataProvider : UPCGComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}