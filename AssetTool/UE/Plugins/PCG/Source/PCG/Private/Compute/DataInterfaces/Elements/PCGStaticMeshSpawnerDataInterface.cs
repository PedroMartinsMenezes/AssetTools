namespace AssetTool
{
    [JsonAsset("PCGStaticMeshSpawnerDataInterface")]
    public class UPCGStaticMeshSpawnerDataInterface : UPCGComputeDataInterface
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGStaticMeshSpawnerDataProvider")]
    public class UPCGStaticMeshSpawnerDataProvider : UComputeDataProvider
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}