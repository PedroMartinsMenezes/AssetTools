namespace AssetTool
{
    [JsonAsset("PCGSpawnSplineSettings")]
    public class UPCGSpawnSplineSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}