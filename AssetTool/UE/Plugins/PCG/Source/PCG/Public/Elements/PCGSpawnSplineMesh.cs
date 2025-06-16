namespace AssetTool
{
    [JsonAsset("PCGSpawnSplineMeshSettings")]
    public class UPCGSpawnSplineMeshSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}