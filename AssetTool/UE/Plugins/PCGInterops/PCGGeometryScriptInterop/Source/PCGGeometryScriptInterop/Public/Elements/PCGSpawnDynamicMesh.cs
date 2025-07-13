namespace AssetTool
{
    [JsonAsset("PCGSpawnDynamicMeshSettings")]
    public class UPCGSpawnDynamicMeshSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}