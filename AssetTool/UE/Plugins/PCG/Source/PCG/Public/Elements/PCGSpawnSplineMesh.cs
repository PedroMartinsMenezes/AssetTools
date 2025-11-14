namespace AssetTool
{
    [JsonAsset("PCGSpawnSplineMeshSettings")]
    public class UPCGSpawnSplineMeshSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}