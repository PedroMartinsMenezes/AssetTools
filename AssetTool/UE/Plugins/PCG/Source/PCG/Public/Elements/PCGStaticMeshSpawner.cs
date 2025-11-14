namespace AssetTool
{
    [JsonAsset("PCGStaticMeshSpawnerSettings")]
    public class UPCGStaticMeshSpawnerSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}