namespace AssetTool
{
    [JsonAsset("PCGCreateEmptyDynamicMeshSettings")]
    public class UPCGCreateEmptyDynamicMeshSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}