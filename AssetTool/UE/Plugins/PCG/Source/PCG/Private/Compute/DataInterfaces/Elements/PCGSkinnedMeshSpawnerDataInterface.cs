namespace AssetTool
{
    [JsonAsset("PCGSkinnedMeshSpawnerDataInterface")]
    public class UPCGSkinnedMeshSpawnerDataInterface : UPCGComputeDataInterface
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSkinnedMeshSpawnerDataProvider")]
    public class UPCGSkinnedMeshSpawnerDataProvider : UPCGComputeDataProvider
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}