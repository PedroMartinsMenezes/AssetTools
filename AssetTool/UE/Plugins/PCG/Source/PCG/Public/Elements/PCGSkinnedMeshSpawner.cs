namespace AssetTool
{
    [JsonAsset("PCGSkinnedMeshSpawnerSettings")]
    public class UPCGSkinnedMeshSpawnerSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}