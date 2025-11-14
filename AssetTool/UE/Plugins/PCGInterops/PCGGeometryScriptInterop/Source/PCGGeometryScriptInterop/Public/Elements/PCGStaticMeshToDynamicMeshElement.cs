namespace AssetTool
{
    [JsonAsset("PCGStaticMeshToDynamicMeshSettings")]
    public class UPCGStaticMeshToDynamicMeshSettings : UPCGDynamicMeshBaseSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}