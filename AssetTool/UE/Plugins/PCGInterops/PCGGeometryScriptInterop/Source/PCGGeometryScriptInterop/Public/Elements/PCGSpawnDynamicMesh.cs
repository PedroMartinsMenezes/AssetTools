namespace AssetTool
{
    [JsonAsset("PCGSpawnDynamicMeshSettings")]
    public class UPCGSpawnDynamicMeshSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}