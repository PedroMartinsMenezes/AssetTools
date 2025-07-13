namespace AssetTool
{
    [JsonAsset("PCGSaveDynamicMeshToAssetSettings")]
    public class UPCGSaveDynamicMeshToAssetSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}