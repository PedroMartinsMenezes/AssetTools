namespace AssetTool
{
    [JsonAsset("PCGStaticMeshSpawnerDataInterface")]
    public class UPCGStaticMeshSpawnerDataInterface : UPCGComputeDataInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGStaticMeshSpawnerDataProvider")]
    public class UPCGStaticMeshSpawnerDataProvider : UComputeDataProvider
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}