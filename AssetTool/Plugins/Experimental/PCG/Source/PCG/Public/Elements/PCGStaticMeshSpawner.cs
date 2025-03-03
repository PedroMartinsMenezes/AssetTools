namespace AssetTool
{
    [JsonAsset("PCGStaticMeshSpawnerSettings")]
    public class UPCGStaticMeshSpawnerSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}