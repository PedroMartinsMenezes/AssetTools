namespace AssetTool
{
    [JsonAsset("PCGSkinnedMeshSpawnerSettings")]
    public class UPCGSkinnedMeshSpawnerSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}