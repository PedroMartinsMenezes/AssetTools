namespace AssetTool
{
    [JsonAsset("PCGSpawnSplineSettings")]
    public class UPCGSpawnSplineSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}