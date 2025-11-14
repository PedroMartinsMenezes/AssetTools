namespace AssetTool
{
    [JsonAsset("PCGMergeDynamicMeshesSettings")]
    public class UPCGMergeDynamicMeshesSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}