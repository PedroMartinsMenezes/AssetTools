namespace AssetTool
{
    [JsonAsset("PCGStaticMeshSpawnerSettings")]
    public class UPCGStaticMeshSpawnerSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}