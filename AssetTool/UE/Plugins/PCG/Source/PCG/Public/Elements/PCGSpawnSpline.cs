namespace AssetTool
{
    [JsonAsset("PCGSpawnSplineSettings")]
    public class UPCGSpawnSplineSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}