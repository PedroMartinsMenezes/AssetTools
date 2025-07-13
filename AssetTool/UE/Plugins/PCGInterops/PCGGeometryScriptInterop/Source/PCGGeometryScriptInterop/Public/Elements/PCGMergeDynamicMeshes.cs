namespace AssetTool
{
    [JsonAsset("PCGMergeDynamicMeshesSettings")]
    public class UPCGMergeDynamicMeshesSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}