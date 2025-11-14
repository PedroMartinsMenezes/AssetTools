namespace AssetTool
{
    [JsonAsset("PCGSaveDynamicMeshToAssetSettings")]
    public class UPCGSaveDynamicMeshToAssetSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}